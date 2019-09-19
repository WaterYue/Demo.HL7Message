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

namespace Demo.HL7MessageParser.WinForms
{
    public partial class AlertProfileParserControl : UserControl
    {
        public AlertProfileParserControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                InitializeAP();
            }


            InitializeAP();
        }

        private void InitializeAP()
        {
            txtURL.Text = @"http://localhost:3181/pms-asa/1/";
            txtClientSecret.Text = "CLIENT_SECRET";
            txtPaHospCode.Text = "PATHOSPCODE";

            cbxHKId.DataSource = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };

            scintilla3.FormatStyle(StyleType.Xml);

            scintilla3.Text = @"<alertInputParm>
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

        private void cbxHKId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
