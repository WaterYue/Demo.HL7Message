using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.WebProxy;
using Microsoft.Web.Services3.Security.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Demo.HL7MessageParser
{
    public class SoapPatientVisitParser : IPatientVisitParser
    {
        private string Url;
        private string userName;
        private string password;
        private string pathospcode;

        public SoapPatientVisitParser()
        {
            // resturi, client_secret, pathospcode from  storage(DB,FILE, CACHE)
            Url = "http://localhost:8096/PatientService.asmx";
            userName = "pas-appt-ws-user";
            password = "pas-appt-ws-user-pwd";
            pathospcode = "PATHOSPCODE";
        }
        public void InitializeParam(string restUri, string userName, string password, string pathospcode)
        {
            this.Url = restUri;
            this.userName = userName;
            this.password = password;
            this.pathospcode = pathospcode;
        }

        public Models.PatientDemoEnquiry GetPatientResult(string caseNumber)
        {
            try
            {
                var patientResultXmlElement = CallByProxyClient(caseNumber);


                var result = XmlHelper.XmlDeserialize<Models.PatientDemoEnquiry>(patientResultXmlElement);

                return result;
            }
            catch
            {
                throw;
            }

        }



        private string CallByProxyClient(string caseNumber)
        {
            //init web service proxy 
            PatientService serviceProxy = new PatientService(Url);

            //init UsernameToken, password is the reverted string of username, the same logic in AuthenticateToken
            //  of ServiceUsernameTokenManager class.
            UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);

            // Set the token onto the proxy
            serviceProxy.SetClientCredential(token);

            // Set the ClientPolicy onto the proxy
            serviceProxy.SetPolicy("ClientPolicy");

            //invoke the HelloMyFriend web service method
            try
            {
                var res = serviceProxy.searchHKPMIPatientByCaseNo(new WebProxy.SearchHKPMIPatientByCaseNo
                {
                    caseNo = caseNumber,
                    hospitalCode = pathospcode
                });

                var resStr = XmlHelper.XmlSerializeToString(res.PatientDemoEnquiryResult);

                //  XmlHelper.FormatXML(resStr);

                return resStr;

            }
            catch (Exception ex)
            {
                //Logger
                throw ex;
            }
        }

    }
}
