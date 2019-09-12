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
        public PatientDemoEnquiry GetPatientResult(string CaseNum)
        {
            var result = SoapProcessHelper.DoProcess();

            return result;
        }
    }
}
