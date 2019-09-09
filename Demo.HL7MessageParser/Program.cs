using Demo.HL7MessageParser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //SoapProcessHelper.DoProcess();

            IHL7MessageParser parser = new HL7MessageParser_NTEC();

            var caseNo = "";
            parser.GetPatient(caseNo);

            parser.GetOrders(caseNo);
        }
    }
}
