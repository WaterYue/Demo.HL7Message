using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Demo.HL7MessageParser
{
    public class JSONMedicationProfileParser : IMedicationProfileParser
    {
        private string restUri;
        private string client_secret;
        private string pathospcode;

        public JSONMedicationProfileParser()
        {
            // resturi, client_secret, pathospcode from  storage(DB,FILE, CACHE)
            restUri = "http://localhost:3181/pms-asa/1/";
            client_secret = "CLIENT_SECRET";
            pathospcode = "PATHOSPCODE";
        }

        public JSONMedicationProfileParser(string restUri, string client_secret, string pathospcode)
        {
            this.restUri = restUri;
            this.client_secret = client_secret;
            this.pathospcode = pathospcode;
        }

        public void InitializeParam(string restUri, string client_secret, string pathospcode)
        {
            this.restUri = restUri;
            this.client_secret = client_secret;
            this.pathospcode = pathospcode;
        }

        public MedicationProfileResult GetMedicationProfile(string caseNumber)
        {
            var client = new RestClient(restUri);

            var request = new RestRequest(string.Format("medProfiles/{0}", caseNumber), Method.GET);
            request.AddHeader("client_secret", client_secret);
            request.AddHeader("pathospcode", pathospcode);

            var response = client.Execute<MedicationProfileResult>(request);

            if (!response.IsSuccessful())
            {
                //response is unsuccessful, throw exception
                response.ThrowException();
            }

            var result = response.Data;

            return result;
        }

    }
}
