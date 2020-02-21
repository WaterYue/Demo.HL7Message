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
using System.Xml;
using System.IO;
using System.Xml.Linq;
using Demo.HL7MessageParser.Models;
using NLog;
using System.Configuration;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class AlertProfileParserControl : UserControl
    {
        private List<string> hkIds = new List<string>();

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public AlertProfileParserControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                InitializeAP();
            }

            InitializeAP();
        }

        private void cbxHKId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hkId = cbxHKId.Text.Trim();
            if (!string.IsNullOrEmpty(hkId))
            {
                scintillaReq.Focus();

                tcMain.SelectedIndex = 0;
                scintillaReq.Text = XmlHelper.FormatXML(XmlFromFile(hkId));

                scintillaReq.FormatStyle(StyleType.Xml);
            }
        }
        private void cbxHKId_TextChanged(object sender, EventArgs e)
        {
            var hkId = cbxHKId.Text.Trim();
            if (!string.IsNullOrEmpty(hkId))
            {
                if (!hkIds.Contains(hkId.ToUpper()))
                {
                    var str = @"<alertInputParm>
    <patientInfo>
        <hkid>{0}</hkid>
        <name>Cook</name>
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
        <accessCode>{1}</accessCode>
    </credentials>
</alertInputParm>";

                    scintillaReq.Text = string.Format(str, hkId, Global.AccessCode);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            scintillaRes.Text = string.Empty;

            var loadData = new LoadDataThreadHelper<RestRequestParam, AlertProfileResult>();

            loadData.Initialize(ParserHelper.ProcessAlertProfile);

            loadData.Completed += (AlertProfileResult data) =>
            {
                if (data != null)
                {
                    var responseJsonStr = JsonHelper.ToJson(data);

                    this.SafeInvoke(() =>
                    {
                        scintillaRes.FormatJsonStyle();

                        scintillaRes.Focus();

                        tcMain.SelectedIndex = 1;

                        scintillaRes.Text = JsonHelper.FormatJson(responseJsonStr);

                    }, false);
                }
            };

            loadData.Exceptioned += (Exception ex) =>
            {
                logger.Error(ex, ex.Message);

                this.SafeInvoke(() =>
                {
                    if (ex is AMException)
                    {
                        var restEx = ex as AMException;

                        MessageBox.Show(string.Format("HttpStatusCode:{1}", restEx.Message, restEx.HttpStatusCode));
                        return;
                    }

                    MessageBox.Show(string.Format("Unknown Exception: {0}", ex.Message));

                }, false);

            };

            loadData.LoadDataAsync(new RestRequestParam
            {
                url = Global.ProfileRestUrl,
                clientsecret = Global.ClientSecret,
                accessCode = Global.AccessCode,
                pahospCode = Global.HospitalCode,
                xmlReq = scintillaReq.Text.Trim()
            });
        }

        private void InitializeAP()
        {
            try
            {
                var alertsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data/AP");
                var alerts = Directory.GetFiles(alertsDir, "*.json");

                hkIds = alerts.Select(o => new FileInfo(o).Name)
                                                .Select(o => o.Substring(0, o.Length - ".json".Length))
                                                .ToList();
            }
            catch (Exception)
            {
                throw;
            }
            //hkIds = new List<string>
            //{
            //    "HN03191100Y",
            //    "HN17000256S",
            //    "HN18001140Y",
            //    "HN170002512",
            //    "HN170002520",
            //    "INVALID_HKID",
            //    "INVALID_PATIENT",
            //    "INVALID_ACCESSCODE"
            //};

            cbxHKId.DataSource = hkIds;
            scintillaReq.FormatStyle(StyleType.Xml);

            scintillaReq.Text = @"<alertInputParm>
    <patientInfo>
        <hkid>HKID_DEMO</hkid>
        <name>Bob</name>
        <dob>19560809</dob>
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
        private static string XmlFromFile(string hkId)
        {
            try
            {
                var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Data/AP/RQ/{0}.xml", hkId));

                var doc = XElement.Load(fileName);

                return doc.ToString();
            }
            catch
            {
                var errorStr = string.Format("LoadXmlFromFile - {0}.xml failed!", hkId);

                return string.Empty;
            }
        }
    }
}
