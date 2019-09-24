using System;
using System.Collections.Generic;
using System.Linq;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.Test.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.HL7MessageParser.Test
{
    [TestClass]
    public class Hl7MessageParserTest
    {
        IHL7MessageParser hl7Parser;

        [TestInitialize]
        public void Initialize()
        {
            hl7Parser = new HL7MessageParser_NTEC
                (
                new FakeSoapPatientVisitParser(),
                new FakeJSONMedicationProfileParser(),
                new FakeJsonIAlertProfileParser()
                );
        }

        [TestMethod]
        public void Test_Patient_Succeed()
        {
            var expectPatient = new PatientVisit();

            var caseNo = "";

            var actualPatientVisit = hl7Parser.GetPatient(caseNo);

            Assert.AreEqual<PatientVisit>(expectPatient, actualPatientVisit);
        }

        [TestMethod]
        public void Test_Order_Succeed()
        {
            var expectObj = new List<Order>();

            var caseNo = "HN18001140Y";

            var actualObj = hl7Parser.GetOrders(caseNo);

            Assert.IsNotNull(actualObj);
            Assert.AreEqual<int>(expectObj.Count, actualObj.Count());
            Assert.AreEqual<IEnumerable<Order>>(expectObj, actualObj);
        }


        [TestMethod]
        public void Test_Allergies_Succeed()
        {
            var expectObj = new List<Allergy>();

            var actualObj = hl7Parser.GetAllergies(new AlertInputParm
            {
                PatientInfo = new PatientInfo
                {
                    Hkid = "HN170002520"
                }
            });

            Assert.IsNotNull(actualObj);
            Assert.AreEqual<int>(expectObj.Count, actualObj.Count());
            Assert.AreEqual<IEnumerable<Allergy>>(expectObj, actualObj);
        }



        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
