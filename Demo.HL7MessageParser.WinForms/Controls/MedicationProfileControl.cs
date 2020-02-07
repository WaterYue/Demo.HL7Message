using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.Common;
using NLog;
using System.Configuration;
using System.IO;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class MedicationProfileControl : UserControl
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public MedicationProfileControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                InitializeMP();
            }

            InitializeMP();
        }

        private void InitializeMP()
        {
            txtURL.Text = Global.RestUri;

            txtClientSecret.Text = ConfigurationManager.AppSettings["client_secret"];
            txtPaHospCode.Text = ConfigurationManager.AppSettings["patHospCode"];

            try
            {
                var profilesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data/MP");
                var profiles = Directory.GetFiles(profilesDir, "*.json");

                cbxCaseNumber.DataSource = profiles.Select(o => new FileInfo(o).Name)
                                                .Select(o => o.Substring(0, o.Length - ".json".Length))
                                                .ToList();
            }
            catch (Exception)
            {
                throw;
            }

         //   cbxCaseNumber.DataSource = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
        }

        private void btnSendMedicationProfile_Click(object sender, EventArgs e)
        {
            // BeginInvoke((MethodInvoker)(() => scintillaRes.Text = string.Empty));
            scintillaRes.Text = string.Empty;

            var loadData = new LoadDataThreadHelper<RestRequestParam, MedicationProfileResult>();

            loadData.Initialize(ParserHelper.ProcessMedicationProfile);

            loadData.Completed += (MedicationProfileResult data) =>
            {
                if (data != null)
                {
                    var responseJsonStr = JsonHelper.ToJson(data);

                    this.SafeInvoke(() =>
                    {
                        scintillaRes.FormatJsonStyle();

                        scintillaRes.Focus();
                        tcBottom.SelectedIndex = 1;
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
                url = txtURL.Text.Trim(),
                clientsecret = txtClientSecret.Text.Trim(),
                pahospCode = txtPaHospCode.Text.Trim(),
                casenumber = cbxCaseNumber.Text.Trim()
            });
        }

        private void cbxCaseNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}