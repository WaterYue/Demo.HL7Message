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
            txtURL.Text = @"http://localhost:8096/PatientService.asmx?op=searchHKPMIPatientByCaseNo";

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
            StringBuilder rawSOAP = new StringBuilder();
            rawSOAP.Append(BuildSoapHeader(credid, credpassword));
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

        private static string BuildSoapHeader(string credid, string credpassword)
        {
            var nonce = getNonce();
            string nonceToSend = Convert.ToBase64String(Encoding.UTF8.GetBytes(nonce));
            string utc = DateTime.Now.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"); ;
            StringBuilder rawSOAP = new StringBuilder(@"<soapenv:Envelope xmlns:sear=""http://www.remotesite.com/serviceName"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:web = ""http://webservice.pas.ha.org.hk/""> ");
            rawSOAP.Append(@"<soapenv:Header>");
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            scintillaRes.Text = string.Empty;

        }

        private void scintillaRes_Click(object sender, EventArgs e)
        {

        }
    }
}
