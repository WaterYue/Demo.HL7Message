using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync(cbxCaseNumber.Text.Trim());
            }
        }

        private void HL7MessageParserFormTest_Load(object sender, EventArgs e)
        {
            cbxCaseNumber.DataSource = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
        }

        Loading loadForm;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BeginInvoke((MethodInvoker)(() =>
            {
                loadForm = new Loading();
                loadForm.Width = this.Width;
                loadForm.Height = this.Height;
                loadForm.ShowDialog();
            }));

            EventResult result = new EventResult();

            var caseNumber = e.Argument as string;

            var parser = new HL7MessageParser_NTEC();

            var pv = parser.GetPatient(caseNumber);

            if (pv != null)
            {
                result.PatientVisit = pv;

                var orders = parser.GetOrders(caseNumber);

                if (orders != null)
                {
                    result.Orders = orders.ToList();

                    var allergys = parser.GetAllergies(new Models.AlertInputParm
                    {
                        PatientInfo = new Models.PatientInfo { Hkid = caseNumber },
                        Credentials = new Models.Credentials { AccessCode = "" }
                    });

                    result.Allergies = allergys.ToList();
                }
            }

            e.Result = result;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completed1");
            BeginInvoke((MethodInvoker)(() =>
            {
                loadForm.Close();
            }));
            //如果用户取消了当前操作就关闭窗口。
            if (e.Cancelled)
            {
                this.Close();
            }
            MessageBox.Show("Completed2");

            //计算过程中的异常会被抓住，在这里可以进行处理。
            if (e.Error != null)
            {
                if (e.Error is AMException)
                {
                    var amex = e.Error as AMException;

                    MessageBox.Show(string.Format("{0}-{1}", amex.HttpStatusCode, amex.Message));

                    return;
                }

                MessageBox.Show(e.Error.Message);

                return;
            }
            MessageBox.Show("Completed3");
            if (e.Result is EventResult)
            {
                var result = e.Result as EventResult;
                scintilla1.FormatJsonStyle();
                scintilla1.Text = JsonHelper.FormatJson(JsonHelper.ToJson(result.PatientVisit));

                scintilla2.FormatJsonStyle();
                scintilla2.Text = JsonHelper.FormatJson(JsonHelper.ToJson(result.Orders));

                scintilla3.FormatJsonStyle();
                scintilla3.Text = JsonHelper.FormatJson(JsonHelper.ToJson(result.Allergies));
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public class EventResult
        {
            public PatientVisit PatientVisit { get; set; }
            public List<Order> Orders { get; set; }
            public List<PatientAllergyObj> Allergies { get; set; }
        }
    }
}
