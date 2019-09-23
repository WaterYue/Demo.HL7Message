using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;

namespace Demo.HL7MessageParser.Test.Fake
{
    public class FakeSoapPatientVisitParser : IPatientVisitParser
    {
        public PatientDemoEnquiry GetPatientResult(string caseNumber)
        {
            var result = SoapParserHelper.LoadSamplePatientDemoEnquiry(caseNumber);

            return result;
        }

        public void InitializeParam(string restUri, string userName, string password, string pathospcode)
        {
            throw new NotImplementedException();
        }
    }
}
