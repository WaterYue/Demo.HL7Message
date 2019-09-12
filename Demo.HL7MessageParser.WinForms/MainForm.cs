using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using RestSharp;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeMP();


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

                    JsonStyle(scintillaResMP);

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

        private void JsonStyle(Scintilla scintillaNET)
        {
            scintillaNET.Styles[Style.Json.Default].ForeColor = Color.Silver;
            scintillaNET.Styles[Style.Json.BlockComment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintillaNET.Styles[Style.Json.LineComment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintillaNET.Styles[Style.Json.Number].ForeColor = Color.Olive;
            scintillaNET.Styles[Style.Json.PropertyName].ForeColor = Color.Blue;
            scintillaNET.Styles[Style.Json.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintillaNET.Styles[Style.Json.StringEol].BackColor = Color.Pink;
            scintillaNET.Styles[Style.Json.Operator].ForeColor = Color.Purple;
            scintillaNET.Lexer = ScintillaNET.Lexer.Json;
             
        }
    }
}
