using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public void Test_GetMedicationProfile_Succeed()
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
        [ExpectedException(typeof(Exception), "invalid INVALID_CLIENT_SECRET value of client_secret!")]
        public void Test_GetMedicationProfile_Invalid_Client_Secret()
        {
            var expectedProfile = new MedicationProfileResult();

            var localParser = new JSONMedicationProfileParser(restUri, "INVALID_CLIENT_SECRET", "PATHOSPCODE");

            var caseNumber = "INVALID_CLIENT_SECRET";

            var actualProfile = localParser.GetMedicationProfile(caseNumber);

            Assert.AreEqual<MedicationProfileResult>(expectedProfile, actualProfile);
        }

        //https://www.nuget.org/packages/MSTestExtensions/4.0.0
        [TestMethod]
        public void Test_GetMedicationProfile_Invalid_Client_Secret_WithMSExtension()
        {
            var caseNumber = "INVALID_CLIENT_SECRET";
            var errorMessage = "Invalid INVALID_CLIENT_SECRET value of client_secret!";

            var localParser = new JSONMedicationProfileParser(restUri, "INVALID_CLIENT_SECRET", "PATHOSPCODE");

            var actualException = Assert.ThrowsException<Exception>(() => localParser.GetMedicationProfile(caseNumber), errorMessage);

            Assert.AreEqual(actualException.Message, errorMessage);
        }

        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
