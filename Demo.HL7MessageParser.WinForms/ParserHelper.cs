using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HL7MessageParser
{
    public static class ParserHelper
    {
        public static MedicationProfileResult ProcessMedicationProfile(RestRequestParam requestParam)
        {
            IMedicationProfileParser parser = new JSONMedicationProfileParser();

            parser.InitializeParam(requestParam.url, requestParam.clientsecret, requestParam.pahospCode);

            return parser.GetMedicationProfile(requestParam.casenumber);
        }

        public static AlertProfileResult ProcessAlertProfile(RestRequestParam requestParam)
        {
            IAlertProfileParser parser = new JSONIAlertProfileParser();

            parser.InitializeParam(requestParam.url, requestParam.clientsecret, requestParam.clientid, requestParam.pahospCode);

            var inputParam = XmlHelper.XmlDeserialize<AlertInputParm>(requestParam.xmlReq);

            return parser.GetAlertProfile(inputParam);
        }
    }

    public class RestRequestParam
    {
        public string url { get; set; }
        public string casenumber { get; set; }
        public string clientsecret { get; set; }
        public string clientid { get; set; }
        public string pahospCode { get; set; }

        public string xmlReq { get; set; }

        public string jsonReq { get; set; }
    }
}
