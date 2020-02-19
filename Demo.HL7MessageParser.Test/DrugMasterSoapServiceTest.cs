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
    public class DrugMasterSoapServiceTest
    {
        IDrugMasterSoapService parser;
        string restUri = "http://localhost:3181/pms-asa/1/";
        [TestInitialize]
        public void Initialize()
        {
        }

      
        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
