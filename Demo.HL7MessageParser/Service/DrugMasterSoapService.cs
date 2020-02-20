using AutoMapper;
using Demo.HL7MessageParser.Common;
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
        private DrugMasterServiceProxy soapservice = new DrugMasterServiceProxy("http://localhost:44368/DrugMasterService.asmx");

        public GetDrugMdsPropertyHqResponse getDrugMdsPropertyHq(Models.GetDrugMdsPropertyHqRequest request)
        {

            var returnResponse = soapservice.getDrugMdsPropertyHq(request);

            return new GetDrugMdsPropertyHqResponse { Return = returnResponse.ToList() };
        }

        public Models.GetPreparationResponse getPreparation(Models.GetPreparationRequest request)
        {
            var returnResponse = soapservice.getPreparation(request);

            return returnResponse;
        }
    }
}
