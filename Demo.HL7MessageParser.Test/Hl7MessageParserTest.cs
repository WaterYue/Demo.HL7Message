using System;
using System.Collections.Generic;
using System.Linq;
using Demo.HL7MessageParser.DTOs;
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
            //hl7Parser = new HL7MessageParser_NTEC
            //    (
            //        new FakeSoapPatientVisitParser(),
            //        new FakeProfileRestService()
            //    );
        }

        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
