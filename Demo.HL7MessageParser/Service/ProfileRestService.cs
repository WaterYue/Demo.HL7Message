﻿using Demo.HL7MessageParser.Common;
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
    public sealed class ProfileRestService : IProfileRestService
    {
        private string restUri;
        private string client_secret;
        private string client_id;
        private string pathospcode;

        public ProfileRestService()
        {
            restUri = "http://localhost:3181/pms-asa/1/";
            client_secret = "CLIENT_SECRET";
            client_id = "CLIENT_ID";
            pathospcode = "PATHOSPCODE";
        }

        public ProfileRestService(string restUri, string client_secret, string client_id, string pathospcode)
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

        public MedicationProfileResult GetMedicationProfile(string caseNumber)
        {
            var client = new RestClient(restUri);
            //The first call is so slower
            //https://stackoverflow.com/questions/12259964/why-is-my-initial-call-in-restsharp-really-slow-but-others-after-are-very-fast
            client.Proxy = CallFasterWebProxy.Default;

            var request = new RestRequest(string.Format("medProfiles/{0}", caseNumber), Method.GET);
            request.AddHeader("Content-Type", "application/json");
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

        public AlertProfileResult GetAlertProfile(AlertInputParm alertinput)
        {
            var client = new RestClient(restUri);
            var request = new RestRequest("alertProfile", Method.POST);
            request.AddHeader("client_secret", client_secret);
            request.AddHeader("client_id", client_id);
            request.AddHeader("pathospcode", pathospcode);

            request.XmlSerializer = new DotNetXmlSerializer();
            //request.AddXmlBody(alertinput);

            /*We must set the Content-Type is 'application/json' and with Xml request body to adjust the customer's interface:
                    POST /pms-asa/1/alertProfile
                    client_secret: G5nWL4fdPQp3XbWTm9qaQUbedsN4zMzVmn5CfeKxkwjteHGw6SreJJCS8gVD74RN
                    client_id: dispCabinet
                    pathospcode:
                    content-type: application/json
                    cache-control: no-cache
                    accept: *//*
                    host: pmssvc-corp-int-uat:26862
                    accept-encoding: gzip, deflate
                    content-length: 562

                    <alertInputParm>
                     <patientInfo>
                     <hkid> I001362A</hkid>
                     <name>PATIENT, 1362</name>
                     </patientInfo>
                     <userInfo>
                     </userInfo>
                     <sysInfo>
                     </sysInfo>
                     <credentials>
                     <accessCode>YAYRoZAJoaYD5qYZbwjQsTGI</accessCode>
                     </credentials>
                     </alertInputParm>
                   */

            var xmlRequestBody = XmlHelper.XmlSerializeToString(alertinput);
            request.AddParameter("application/json", xmlRequestBody, ParameterType.RequestBody);

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
