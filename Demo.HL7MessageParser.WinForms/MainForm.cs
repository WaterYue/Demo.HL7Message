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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Global.Initialize();
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
            TabControl tc = new TabControl { Dock = DockStyle.Fill };

            tc.TabPages.Add(new TabPage { Name = "tbPatientDemographic", Text = "PatientDemographic" });
            tc.TabPages["tbPatientDemographic"].Controls.Add(new PatientDemographicControl { Dock = DockStyle.Fill });

            tc.TabPages.Add(new TabPage { Name = "tbMedicationProfile", Text = "MedicationProfile" });
            tc.TabPages["tbMedicationProfile"].Controls.Add(new MedicationProfileControl { Dock = DockStyle.Fill });

            tc.TabPages.Add(new TabPage { Name = "tbAlertProfile", Text = "AlertProfileControl" });
            tc.TabPages["tbAlertProfile"].Controls.Add(new AlertProfileParserControl { Dock = DockStyle.Fill });

            tc.TabPages.Add(new TabPage { Name = "PatientOrderAlerts", Text = "PatientOrderAlertControl" });
            tc.TabPages["PatientOrderAlerts"].Controls.Add(new PatientOrderAlertControl { Dock = DockStyle.Fill });


            

            Controls.Add(tc);
        }
    }
}
