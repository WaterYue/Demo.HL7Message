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
    public class JSONIAlertProfileParserTest
    {
        IAlertProfileParser parser;
        string restUri = "http://localhost:3181/pms-asa/1/";
        [TestInitialize]
        public void Initialize()
        {
            parser = new JSONIAlertProfileParser();
        }

        [TestMethod]
        public void Test_GetAlertProfile_Successful()
        {
            var alertInputParam = new AlertInputParm { PatientInfo = new PatientInfo { Hkid = "HN170002520" } };

            var relateivePath = string.Format("Data/AP/{0}.json", alertInputParam.PatientInfo.Hkid);
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relateivePath);

            var expectedProfile = JsonHelper.JsonToObjectFromFile<AlertProfileResult>(fileName);

            Assert.IsNotNull(expectedProfile);
            var expectedProfileJSONStr = JsonHelper.ToJson(expectedProfile);


            var actualProfile = parser.GetAlertProfile(alertInputParam);
            Assert.IsNotNull(expectedProfile);

            var actualProfileJSONStr = JsonHelper.ToJson(actualProfile);

            Assert.AreEqual(expectedProfileJSONStr, actualProfileJSONStr);
        }

        [TestMethod]
        public void Test_GetAlertProfile_Invalid_HKID()
        {
            var caseNumber = new AlertInputParm { PatientInfo = new PatientInfo { Hkid = "INVALID_HKID" } };

            var actualProfile = parser.GetAlertProfile(caseNumber);

            Assert.IsNotNull(actualProfile);
            Assert.AreEqual(actualProfile.AdrProfile.Count, 0);
            Assert.AreEqual(actualProfile.AlertProfile.Count, 0);
            Assert.AreEqual(actualProfile.AllergyProfile.Count, 0);

            Assert.IsNull(actualProfile.MoePatientSteroidTag);

            Assert.IsNotNull(actualProfile.ErrorMessage);
            Assert.IsNotNull(actualProfile.ErrorMessage[0].MsgCode, "20001");
        }

        [TestMethod]
        public void Test_GetAlertProfile_Invalid_AccessCode()
        {
            var caseNumber = new AlertInputParm { PatientInfo = new PatientInfo { Hkid = "INVALID_ACCESSCODE" } };

            var actualProfile = parser.GetAlertProfile(caseNumber);

            Assert.IsNotNull(actualProfile);
            Assert.AreEqual(actualProfile.AdrProfile.Count, 0);
            Assert.AreEqual(actualProfile.AlertProfile.Count, 0);
            Assert.AreEqual(actualProfile.AllergyProfile.Count, 0);

            Assert.IsNull(actualProfile.MoePatientSteroidTag);

            Assert.IsNotNull(actualProfile.ErrorMessage);
            Assert.IsNotNull(actualProfile.ErrorMessage[0].MsgCode, "20083");
        }

        [TestMethod]
        public void Test_GetAlertProfile_Invalid_PatientInfo()
        {
            var caseNumber = new AlertInputParm { PatientInfo = new PatientInfo { Hkid = "INVALID_PATIENT" } };

            var actualProfile = parser.GetAlertProfile(caseNumber);

            Assert.IsNotNull(actualProfile);
            Assert.AreEqual(actualProfile.AdrProfile.Count, 0);
            Assert.AreEqual(actualProfile.AlertProfile.Count, 0);
            Assert.AreEqual(actualProfile.AllergyProfile.Count, 0);

            Assert.IsNull(actualProfile.MoePatientSteroidTag);

            Assert.IsNotNull(actualProfile.ErrorMessage);
            Assert.IsNotNull(actualProfile.ErrorMessage[0].MsgCode, "20002");
        }

        [TestMethod]
        public void Test_GetAlertProfile_Invalid_Client_Secret()
        {
            var alertInput = new AlertInputParm { PatientInfo = new PatientInfo { Hkid = "INVALID_CLIENT_SECRET" } };
            var errorMessage = "Unauthorized";
            var httpStatusCode = HttpStatusCode.Unauthorized;

            var localParser = new JSONIAlertProfileParser(restUri, "INVALID_CLIENT_SECRET", "CLIENT_ID", "PATHOSPCODE");

            var actualException = Assert.ThrowsException<RestException>(() => localParser.GetAlertProfile(alertInput));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
            Assert.AreEqual(actualException.Message, errorMessage);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Service_NotFound()
        {
            var alertInput = new AlertInputParm { };

            var httpStatusCode = HttpStatusCode.NotFound;

            // var localParser = new JSONMedicationProfileParser("http://localhost:3181/pms-asa/invalidurl/", "CLIENT_SECRET", "PATHOSPCODE");
            var localParser = new JSONIAlertProfileParser("https://en.wikipedia.org/wiki/Main_Page/", "CLIENT_SECRET", "CLIENT_ID", "PATHOSPCODE");
            var actualException = Assert.ThrowsException<RestException>(() => localParser.GetAlertProfile(alertInput));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
        }

        [TestMethod]
        public void Test_GetMedicationProfile_Service_Unavailable()
        {
            var alertInput = new AlertInputParm { };

            var httpStatusCode = HttpStatusCode.ServiceUnavailable;

            //  var localParser = new JSONMedicationProfileParser("http://localhost:3181/pms-asa/invalidurl/", "CLIENT_SECRET", "PATHOSPCODE");
            var localParser = new JSONIAlertProfileParser("http://localhost:9527/pms-asa/invalidurl/", "CLIENT_SECRET", "CLIENT_ID", "PATHOSPCODE");
            var actualException = Assert.ThrowsException<RestException>(() => localParser.GetAlertProfile(alertInput));

            Assert.AreEqual(actualException.HttpStatusCode, httpStatusCode);
        }

        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
