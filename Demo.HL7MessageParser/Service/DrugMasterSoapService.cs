using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.WebProxy;
using Microsoft.Web.Services3.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public class DrugMasterSoapService : IDrugMasterSoapService
    {
        private PreparationService soapservice = new PreparationService("http://localhost:44368/PreparationService.asmx");

        public GetDrugMdsPropertyHqResponse getDrugMdsPropertyHq(Models.getDrugMdsPropertyHq request)
        {
            var r = new WebProxy.getDrugMdsPropertyHq();
            var rs1 = soapservice.getDrugMdsPropertyHq(r);

            return new GetDrugMdsPropertyHqResponse();
        }

        public Models.GetPreparationResponse getPreparation(Models.GetPreparationRequest request)
        {
            var rs2 = soapservice.getPreparation(new WebProxy.GetPreparationRequest { arg0 = new WebProxy.Arg0 { itemCode = "AMET02" } });
            return null;
        }
    }
}
