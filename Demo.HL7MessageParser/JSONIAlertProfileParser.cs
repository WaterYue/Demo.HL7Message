using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Demo.HL7MessageParser
{
    public class JSONIAlertProfileParser : IAlertProfileParser
    {
        private string restUri;
        private string client_secret;
        private string client_id;
        private string pathospcode;

        public JSONIAlertProfileParser()
        {
            restUri = "http://localhost:3181/pms-asa/1/";
            client_secret = "CLIENT_SECRET";
            client_id = "CLIENT_ID";
            pathospcode = "PATHOSPCODE";
        }

        public JSONIAlertProfileParser(string restUri, string client_secret, string client_id, string pathospcode)
        {
            Initialize(restUri, client_secret, client_id, pathospcode);
        }

        public void Initialize(string restUri, string client_secret, string client_id, string pathospcode)
        {
            this.restUri = restUri;
            this.client_secret = client_secret;
            this.client_id = client_id;
            this.pathospcode = pathospcode;
        }


        public AlertProfileResult GetAlertProfile(AlertInputParm alertinput)
        {
            var client = new RestClient(restUri);

            var request = new RestRequest("alertProfile", Method.POST);
           // request.AddHeader("Content-Type", "application/xml");

            request.AddHeader("client_secret", client_secret);
            request.AddHeader("client_id", client_id);
            request.AddHeader("pathospcode", pathospcode);
           
            request.RequestFormat = DataFormat.Xml;
            request.XmlSerializer = new DotNetXmlSerializer();
            request.AddBody(alertinput);

            var response = client.Execute<AlertProfileResult>(request);

            if (!response.IsSuccessful())
            {
                response.ThrowException();
            }

            var result = response.Data;

            if (IsInvalidResponseResult(result))
            {
                var errorMsg = string.Format("Invalid Request:{0}-{1}", result.ErrorMessage[0].MsgCode, result.ErrorMessage[0].MsgText);

                throw new AMException(HttpStatusCode.Unauthorized, errorMsg, null);
            }

            return result;
        }

        private static bool IsInvalidResponseResult(AlertProfileResult result)
        {
            return result.ErrorMessage != null
                && result.ErrorMessage.Count > 0
                && string.Compare(result.ErrorMessage[0].MsgCode, string.Empty) != 0;
        }
    }
}
