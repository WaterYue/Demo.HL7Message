using AutoMapper;
using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.WebProxy;
using Microsoft.Web.Services3.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Demo.HL7MessageParser
{
    public class DrugMasterSoapService : IDrugMasterSoapService
    {
        private DrugMasterServiceProxy soapService;

        public string Url { get; private set; }

        public DrugMasterSoapService(string url)
        {
            Url = url;

            soapService = new DrugMasterServiceProxy(url);
        }

        public GetDrugMdsPropertyHqResponse getDrugMdsPropertyHq(Models.GetDrugMdsPropertyHqRequest request)
        {
            var response = soapService.getDrugMdsPropertyHq(request);

            return new GetDrugMdsPropertyHqResponse { Return = response.ToList() };
        }

        public Models.GetPreparationResponse getPreparation(Models.GetPreparationRequest request)
        {
            var returnResponse = soapService.getPreparation(request);

            return returnResponse;
        }
    }
}
