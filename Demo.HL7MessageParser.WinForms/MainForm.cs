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

            //if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            //{
            //    tcMain.TabPages[0].Controls.Add(new MedicationProfileControl { Dock = DockStyle.Fill });
            //}
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                case Keys.F2:
                    {
                        new HL7MessageParserFormTest().ShowDialog();
                        return true;
                    }
                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            tpMedicationProfile.Controls.Add(new MedicationProfileControl { Dock = DockStyle.Fill });

            tpAlertProfile.Controls.Add(new AlertProfileParserControl { Dock = DockStyle.Fill });

            tpPatientDemographic.Controls.Add(new PatientDemographicControl { Dock = DockStyle.Fill });
        }
    }
}
