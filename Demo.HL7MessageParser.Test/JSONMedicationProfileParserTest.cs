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
    public class JSONMedicationProfileParserTest
    {
        IMedicationProfileParser parser;
        string restUri = "http://localhost:3181/pms-asa/1/";
        [TestInitialize]
        public void Initialize()
        {
            parser = new JSONMedicationProfileParser();

            parser.InitializeParam();
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Successful()
        {
            var caseNumber = "HN170002512";

            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Data/MP/{0}.json", caseNumber));

            var expectedProfile = JsonHelper.JsonToObjectFromFile<MedicationProfileResult>(fileName);

            Assert.IsNotNull(expectedProfile);
            var expectedProfileJSONStr = JsonHelper.ToJson(expectedProfile);


            var actualProfile = parser.GetMedicationProfile(caseNumber);
            Assert.IsNotNull(expectedProfile);

            var actualProfileJSONStr = JsonHelper.ToJson(actualProfile);

            Assert.AreEqual(expectedProfileJSONStr, actualProfileJSONStr);
        }



        [TestMethod]
        public void Test_GetMedicationProfile_Invalid_CasseNumber()
        {
            var caseNumber = "Invalid_CaseNumber";

            var actualProfile = parser.GetMedicationProfile(caseNumber);

            Assert.IsNotNull(actualProfile);
            Assert.IsNull(actualProfile.MedProfileId);
            Assert.IsNull(actualProfile.CaseNum);
            Assert.IsNull(actualProfile.MedProfileMoItems);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Invalid_PATHOSPCODE()
        {
            var caseNumber = "Any_CaseNumber";
            var localParser = new JSONMedicationProfileParser(restUri, "CLIENT_SECRET", "INVALID_PATHOSPCODE");

            var actualProfile = localParser.GetMedicationProfile(caseNumber);

            Assert.IsNotNull(actualProfile);
            Assert.IsNull(actualProfile.MedProfileId);
            Assert.IsNull(actualProfile.CaseNum);
            Assert.IsNull(actualProfile.MedProfileMoItems);
        }

        //[TestMethod]
        //[ExpectedException(typeof(RestException), "invalid INVALID_CLIENT_SECRET value of client_secret!")]
        //public void Test_GetMedicationProfile_Invalid_Client_Secret()
        //{
        //    var expectedProfile = new MedicationProfileResult();

        //    var localParser = new JSONMedicationProfileParser(restUri, "INVALID_CLIENT_SECRET", "PATHOSPCODE");

        //    var caseNumber = "INVALID_CLIENT_SECRET";

        //    var actualProfile = localParser.GetMedicationProfile(caseNumber);

        //    Assert.AreEqual<MedicationProfileResult>(expectedProfile, actualProfile);
        //}

        //https://www.nuget.org/packages/MSTestExtensions/4.0.0
        [TestMethod]
        public void Test_GetMedicationProfile_Invalid_Client_Secret()
        {
            var caseNumber = "INVALID_CLIENT_SECRET";

            var errorMessage = "Unauthorized";
            var httpStatusCode = HttpStatusCode.Unauthorized;

            var localParser = new JSONMedicationProfileParser(restUri, "INVALID_CLIENT_SECRET", "PATHOSPCODE");

            var actualException = Assert.ThrowsException<RestException>(() => localParser.GetMedicationProfile(caseNumber));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
            Assert.AreEqual(actualException.Message, errorMessage);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Service_NotFound()
        {
            var caseNumber = "Any_CaseNumber";

            var httpStatusCode = HttpStatusCode.NotFound;

            // var localParser = new JSONMedicationProfileParser("http://localhost:3181/pms-asa/invalidurl/", "CLIENT_SECRET", "PATHOSPCODE");
            var localParser = new JSONMedicationProfileParser("https://en.wikipedia.org/wiki/Main_Page/", "CLIENT_SECRET", "PATHOSPCODE");
            var actualException = Assert.ThrowsException<RestException>(() => localParser.GetMedicationProfile(caseNumber));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Service_Unavailable()
        {
            var caseNumber = "Any_CaseNumber";

            var httpStatusCode = HttpStatusCode.ServiceUnavailable;

            //  var localParser = new JSONMedicationProfileParser("http://localhost:3181/pms-asa/invalidurl/", "CLIENT_SECRET", "PATHOSPCODE");
            var localParser = new JSONMedicationProfileParser("http://localhost:9527/pms-asa/invalidurl/", "CLIENT_SECRET", "PATHOSPCODE");
            var actualException = Assert.ThrowsException<RestException>(() => localParser.GetMedicationProfile(caseNumber));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
        }


        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
