using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public class MDSCheckRestService : IMDSCheckRestService
    {
        private string restUri;
        private string client_secret;
        private string client_id;
        private string pathospcode;

        public MDSCheckRestService()
        {
            restUri = "http://localhost:3181/pms-asa/1/";
            client_secret = "CLIENT_SECRET";
            client_id = "CLIENT_ID";
            pathospcode = "PATHOSPCODE";
        }

        public MDSCheckRestService(string restUri, string client_secret, string client_id, string pathospcode)
        {
            this.restUri = restUri;
            this.client_secret = client_secret;
            this.client_id = client_id;
            this.pathospcode = pathospcode;
        }


        public MDSCheckResult CheckMDS(MDSCheckInputParm inputParam)
        {
            var client = new RestClient(restUri);

            var request = new RestRequest("mdsCheck", Method.POST);

            request.AddHeader("client_secret", client_secret);
            request.AddHeader("client_id", client_id);
            request.AddHeader("pathospcode", pathospcode);

            request.XmlSerializer = new DotNetXmlSerializer();

            var xmlRequestBody = XmlHelper.XmlSerializeToString(inputParam);
            request.AddParameter("application/json", xmlRequestBody, ParameterType.RequestBody);

            var response = client.Execute<MDSCheckResult>(request);

            if (!response.IsSuccessful())
            {
                response.ThrowException();
            }

            var result = response.Data;

            return result;
        }
    }
}
