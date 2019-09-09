using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public class SoapPatientVisitParser : IPatientVisitParser
    {
        public PatientDemoEnquiry GetPatientResult(string CaseNum)
        {
            //SOAP SERVICE CLIENT TO CALLL 

            var pr = SoapProcessHelper.DoProcess();

            return pr;
        }
    }
}
