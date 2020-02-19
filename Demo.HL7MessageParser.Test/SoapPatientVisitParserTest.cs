using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.Test.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.HL7MessageParser.Test
{
    [TestClass]
    public class SoapPatientVisitParserTest
    {
        IPatientVisitParser parser;

        string Uri = "http://localhost:8096/PatientService.asmx";
        [TestInitialize]
        public void Initialize()
        {
            parser = new SoapPatientVisitParser();
        }

        [TestMethod]
        public void Test_GetPatientDemographic_Successful()
        {
            var caseNumber = "HN170002512";

            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Data/PE/{0}.json", caseNumber));

            var expectedProfile = JsonHelper.JsonToObjectFromFile<PatientDemoEnquiry>(fileName);

            Assert.IsNotNull(expectedProfile);

            var expectedProfileJSONStr = JsonHelper.ToJson(expectedProfile);


            var actualProfile = parser.GetPatientResult(caseNumber);
            Assert.IsNotNull(expectedProfile);

            var actualProfileJSONStr = JsonHelper.ToJson(actualProfile);

            Assert.AreEqual(expectedProfileJSONStr, actualProfileJSONStr);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Invalid_CasseNumber()
        {
            var caseNumber = "Invalid_CaseNumber";

            var actualProfile = parser.GetPatientResult(caseNumber);

            Assert.IsNotNull(actualProfile);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Invalid_PATHOSPCODE()
        {
            var caseNumber = "Any_CaseNumber";
            var localParser = new ProfileRestService(Uri, "CLIENT_SECRET", "CLIENT_ID", "INVALID_PATHOSPCODE");

            var actualProfile = localParser.GetMedicationProfile(caseNumber);

            Assert.IsNotNull(actualProfile);
            Assert.IsNull(actualProfile.MedProfileId);
            Assert.IsNull(actualProfile.CaseNum);
            Assert.IsNull(actualProfile.MedProfileMoItems);
        }

       

        //https://www.nuget.org/packages/MSTestExtensions/4.0.0
        [TestMethod]
        public void Test_GetMedicationProfile_Invalid_Client_Secret()
        {
            var caseNumber = "INVALID_CLIENT_SECRET";

            var errorMessage = "Unauthorized";
            var httpStatusCode = HttpStatusCode.Unauthorized;

            var localParser = new ProfileRestService(Uri, "CLIENT_SECRET", "CLIENT_ID", "INVALID_PATHOSPCODE");

            var actualException = Assert.ThrowsException<AMException>(() => localParser.GetMedicationProfile(caseNumber));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
            Assert.AreEqual(actualException.Message, errorMessage);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Service_Unavailable()
        {
            var caseNumber = "Any_CaseNumber";

            var httpStatusCode = HttpStatusCode.ServiceUnavailable;

            //  var localParser = new JSONMedicationProfileParser("http://localhost:3181/pms-asa/invalidurl/", "CLIENT_SECRET", "PATHOSPCODE");
            var localParser = new ProfileRestService("http://localhost:9527/pms-asa/invalidurl/", "CLIENT_SECRET", "CLIENT_ID", "PATHOSPCODE");
            var actualException = Assert.ThrowsException<AMException>(() => localParser.GetMedicationProfile(caseNumber));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
        }

        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
