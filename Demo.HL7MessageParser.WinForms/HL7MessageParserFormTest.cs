using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.WinForms.Lexers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class HL7MessageParserFormTest : Form
    {
        public HL7MessageParserFormTest()
        {
            InitializeComponent();

            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            scintillaAlerts.Text = string.Empty;
            scintillaProfiles.Text = string.Empty;
            scintillaPatient.Text = string.Empty;

            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync(cbxCaseNumber.Text.Trim());

            loadForm = new Loading { Width = this.Width, Height = this.Height };

            loadForm.ShowDialog();
        }

        private void HL7MessageParserFormTest_Load(object sender, EventArgs e)
        {
            var patientsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data/PE/");

            var files = Directory.GetFiles(patientsDir, "*.xml");

            cbxCaseNumber.DataSource = files.Select(o => new FileInfo(o).Name)
                                            .Select(o => o.Substring(0, o.Length - ".xml".Length))
                                            .ToList();

            //  cbxCaseNumber.DataSource = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
        }

        Loading loadForm;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var result = new EventResult();
            e.Result = result;

            var caseNumber = e.Argument as string;

            var parser = new HL7MessageParser_NTEC();

            var pv = parser.GetPatient(caseNumber);

            if (pv != null)
            {
                result.PatientVisit = pv;
                this.BeginInvoke((MethodInvoker)delegate
                {
                    scintillaPatient.FormatStyle(StyleType.Xml);
                    scintillaPatient.Text = XmlHelper.FormatXML(XmlHelper.XmlSerializeToString(result.PatientVisit));
                });
                var orders = parser.GetMedicationProfiles(caseNumber);
                result.Orders = (orders ?? new MedicationProfileResult());
                this.BeginInvoke((MethodInvoker)delegate
                {
                    scintillaProfiles.FormatJsonStyle();
                    scintillaProfiles.Text = JsonHelper.FormatJson(JsonHelper.ToJson(result.Orders));
                });

                var allergys = parser.GetAlertProfiles(new Models.AlertInputParm
                {
                    PatientInfo = new Models.PatientInfo { Hkid = caseNumber },
                    Credentials = new Models.Credentials { AccessCode = "" }
                });
                result.Allergies = (allergys ?? new AlertProfileResult());
                this.BeginInvoke((MethodInvoker)delegate
                {
                    scintillaAlerts.FormatJsonStyle();
                    scintillaAlerts.Text = JsonHelper.FormatJson(JsonHelper.ToJson(result.Allergies));
                });
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (loadForm != null)
            {
                loadForm.Close();
            }

            //如果用户取消了当前操作就关闭窗口。
            if (e.Cancelled)
            {
                this.Close();
            }

            //计算过程中的异常会被抓住，在这里可以进行处理。
            if (e.Error != null)
            {
                if (e.Error is AMException)
                {
                    var amex = e.Error as AMException;

                    MessageBox.Show(string.Format("{0}-{1}", amex.HttpStatusCode, amex.Message));
                }
                else
                {
                    MessageBox.Show(e.Error.Message);
                }

                return;
            }
            /*

            if (e.Result is EventResult)
            {
                var result = e.Result as EventResult;
                scintillaPatient.FormatStyle(StyleType.Xml);
                scintillaPatient.Text = XmlHelper.FormatXML(XmlHelper.XmlSerializeToString(result.PatientVisit));

                scintillaProfiles.FormatJsonStyle();
                scintillaProfiles.Text = JsonHelper.FormatJson(JsonHelper.ToJson(result.Orders));

                scintillaAlerts.FormatJsonStyle();
                scintillaAlerts.Text = JsonHelper.FormatJson(JsonHelper.ToJson(result.Allergies));
            }*/
        }

        public class EventResult
        {
            public PatientDemoEnquiry PatientVisit { get; set; }
            public MedicationProfileResult Orders { get; set; }
            public AlertProfileResult Allergies { get; set; }
        }
    }
}
