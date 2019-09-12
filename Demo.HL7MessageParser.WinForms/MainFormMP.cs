using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.WinForms.Lexers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class MainForm : Form
    {
        private void InitializeAP()
        {
            scintilla3.FormatStyle(StyleType.Xml);

            scintilla3.Text = @"
<alertInputParm>
	<patientInfo>
		<hkid> M1312877</hkid>
		<name>CHUI, Strawberry</name>
		<dob>19430810</dob>
		<sex>F</sex>
		<cccode1>17761</cccode1>
		<cccode2>54301</cccode2>
		<cccode3>54481</cccode3>
		<cccode4></cccode4>
		<cccode5></cccode5>
		<cccode6></cccode6>
	</patientInfo>
	<userInfo>
		<hospCode>VH</hospCode>
		<loginId>itdadmin</loginId>
	</userInfo>
	<sysInfo>
		<wsId>160.68.34.60</wsId>
		<sourceSystem>PMS</sourceSystem>
	</sysInfo>
	<credentials>
		<accessCode>YAYRoZAJoaYD5qYZbwjQsTGI</accessCode>
	</credentials>
</alertInputParm>";
        }

        private void InitializeMP()
        {
            txtURL.Text = @"http://localhost:3181/pms-asa/1/";
            txtClientSecret.Text = "CLIENT_SECRET";
            txtPaHospCode.Text = "PATHOSPCODE";

            cbxCaseNumber.DataSource = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
        }

        private void btnSendMedicationProfile_Click(object sender, EventArgs e)
        {
            var client = new RestClient(txtURL.Text.Trim());
            var request = new RestRequest(string.Format("medProfiles/{0}", cbxCaseNumber.Text.Trim()), Method.GET);
            request.AddHeader("client_secret", txtClientSecret.Text.Trim());
            request.AddHeader("pathospcode", txtPaHospCode.Text.Trim());

            var response = client.Execute<MedicationProfileResult>(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine("request2 failed!");
                Console.WriteLine(response.ResponseStatus);
            }

            else
            {
                var result = response.Data;

                if (result != null)
                {
                    var responseJsonStr = JsonHelper.ToJson(result);

                    scintillaResMP.FormatJsonStyle();

                    scintillaResMP.Focus();
                    tcBottom.SelectedIndex = 1;
                    scintillaResMP.Text = JsonHelper.FormatJson(responseJsonStr);

                }

                //string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Data/AP/{0}.json", "HN170002520"));

                //using (StreamReader reader = new StreamReader(fileName, Encoding.UTF8))
                //{

                //    JsonStyle(scintillaReqMP);

                //    scintillaReqMP.Text = reader.ReadToEnd();

                //}
            }
        }

    }
}
