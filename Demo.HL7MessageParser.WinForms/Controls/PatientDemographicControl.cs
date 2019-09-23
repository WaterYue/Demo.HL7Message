using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.HL7MessageParser.WinForms.Lexers;
using Demo.HL7MessageParser.Common;

using Microsoft.Web.Services3.Security.Tokens;
using System.Net;
using System.IO;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class PatientDemographicControl : UserControl
    {

        public PatientDemographicControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                InitializePE();
            }

            InitializePE();
        }

        private void InitializePE()
        {
            txtURL.Text = @"http://localhost:8096/PatientService.asmx";

            txtUserName.Text = "pas-appt-ws-user";

            txtPassword.Text = "pas-appt-ws-user-pwd";

            txtHospitalCode.Text = "HV";
            cbxCaseNumber.DataSource = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string SOAPObj = BuildRequestSoap();

            scintillaReq.Text = XmlHelper.FormatXML(SOAPObj);

            scintillaReq.FormatStyle(StyleType.Xml);
        }

        private string BuildRequestSoap()
        {
            string credid = txtUserName.Text.Trim();
            string credpassword = txtPassword.Text.Trim();
            string url = txtURL.Text.Trim();

            var actionName = "http://webservice.pas.ha.org.hk/searchHKPMIPatientByCaseNo";

            StringBuilder rawSOAP = new StringBuilder();
            rawSOAP.Append(BuildSoapHeader(credid, credpassword, true, url, actionName));
            rawSOAP.Append(@"<soapenv:Body><web:searchHKPMIPatientByCaseNo>");
            rawSOAP.Append(BuildSearchparms("hospitalCode", txtHospitalCode.Text.Trim()));
            rawSOAP.Append(BuildSearchparms("caseNo", cbxCaseNumber.Text.Trim()));

            rawSOAP.Append(@"</web:searchHKPMIPatientByCaseNo></soapenv:Body></soapenv:Envelope>");

            return rawSOAP.ToString();

        }

        private static string BuildSearchparms(string pName, string pvalue)
        {
            string param = string.Format("<{0}>{1}</{0}>", pName, pvalue);

            return param;
        }

        private static string BuildSoapHeader(string credid, string credpassword, bool enableWS_Address, string url, string actionName)
        {
            var nonce = getNonce();
            string nonceToSend = Convert.ToBase64String(Encoding.UTF8.GetBytes(nonce));
            string utc = DateTime.Now.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"); ;
            StringBuilder rawSOAP = new StringBuilder(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:web=""http://webservice.pas.ha.org.hk/"" ");

            if (enableWS_Address)
            {
                rawSOAP.Append(@"xmlns:wsa = ""http://schemas.xmlsoap.org/ws/2004/08/addressing""");
            }

            rawSOAP.Append(">");
            rawSOAP.Append(@"<soapenv:Header>");

            if (enableWS_Address)
            {
                rawSOAP.Append(string.Format(@"<wsa:Action>{0}</wsa:Action>", actionName));
                rawSOAP.Append(string.Format(@"<wsa:To>{0}</wsa:To>", url));
            }

            rawSOAP.Append(@"<wsse:Security soapenv:mustUnderstand=""1"" xmlns:wsse=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"" xmlns:wsu=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"">");
            rawSOAP.Append(@"<wsse:UsernameToken wsu:Id=""UsernameToken-D1A5C91F8C11FC7F2614479411111111"">");
            rawSOAP.Append(@"<wsse:Username>" + credid + "</wsse:Username>");
            rawSOAP.Append(@"<wsse:Password Type=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"">" + credpassword + "</wsse:Password>");
            rawSOAP.Append(@"<wsse:Nonce EncodingType=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary"">" + nonceToSend + "</wsse:Nonce>");
            rawSOAP.Append(@"<wsu:Created>" + utc + "</wsu:Created>");
            rawSOAP.Append(@"</wsse:UsernameToken>");
            rawSOAP.Append(@"</wsse:Security>");
            rawSOAP.Append(@"</soapenv:Header>");
            return rawSOAP.ToString();
        }

        private static string getNonce()
        {
            string phrase = Guid.NewGuid().ToString();
            return phrase;
        }

        private void btnCallByProxy_Click(object sender, EventArgs e)
        {
            scintillaRes.Text = string.Empty;

            //init web service proxy 
            PatientService serviceProxy = new PatientService();

            //init UsernameToken, password is the reverted string of username, the same logic in AuthenticateToken
            //  of ServiceUsernameTokenManager class.
            UsernameToken token = new UsernameToken("pas-appt-ws-user", "pas-appt-ws-user-pwd", PasswordOption.SendPlainText);

            // Set the token onto the proxy
            serviceProxy.SetClientCredential(token);

            // Set the ClientPolicy onto the proxy
            serviceProxy.SetPolicy("ClientPolicy");

            //invoke the HelloMyFriend web service method
            try
            {
                var res = serviceProxy.searchHKPMIPatientByCaseNo(new SearchHKPMIPatientByCaseNo
                {
                    caseNo = "HN03191100Y",
                    hospitalCode = "HV"
                });

                var resStr = XmlHelper.XmlSerializeToString(res);

                scintillaRes.Focus();
                tcBottom.SelectedIndex = 1;

                scintillaRes.Text = XmlHelper.FormatXML(resStr);
                scintillaRes.FormatStyle(StyleType.Xml);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void scintillaRes_Click(object sender, EventArgs e)
        {

        }

        private void btnCallByWebReq_Click(object sender, EventArgs e)
        {
            string SOAPObj = BuildRequestSoap();
            string url = txtURL.Text.Trim();
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(url + "?op=searchHKPMIPatientByCaseNo") as HttpWebRequest;

                request.ContentType = "text/xml";
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(SOAPObj);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                using (HttpWebResponse webresponse = request.GetResponse() as HttpWebResponse)
                {
                    using (StreamReader reader = new StreamReader(webresponse.GetResponseStream()))
                    {
                        string response = reader.ReadToEnd();


                        scintillaRes.Text = string.Empty;
                        scintillaRes.Focus();
                        tcBottom.SelectedIndex = 1;

                        scintillaRes.Text = XmlHelper.FormatXML(response);
                        scintillaRes.FormatStyle(StyleType.Xml);
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex;
            }
        }
    }
}
