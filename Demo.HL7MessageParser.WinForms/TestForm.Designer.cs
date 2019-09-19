namespace Demo.HL7MessageParser.WinForms
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.medicationProfileControl1 = new Demo.HL7MessageParser.WinForms.MedicationProfileControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alertProfileParserControl1 = new Demo.HL7MessageParser.WinForms.AlertProfileParserControl();
            this.tbPatientDemographic = new System.Windows.Forms.TabPage();
            this.patientDemographicControl1 = new Demo.HL7MessageParser.WinForms.PatientDemographicControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbPatientDemographic.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbPatientDemographic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 799);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.medicationProfileControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 773);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MedicationProfile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // medicationProfileControl1
            // 
            this.medicationProfileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicationProfileControl1.Location = new System.Drawing.Point(3, 3);
            this.medicationProfileControl1.Name = "medicationProfileControl1";
            this.medicationProfileControl1.Size = new System.Drawing.Size(1100, 767);
            this.medicationProfileControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.alertProfileParserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 773);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AlertProfile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // alertProfileParserControl1
            // 
            this.alertProfileParserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertProfileParserControl1.Location = new System.Drawing.Point(3, 3);
            this.alertProfileParserControl1.Name = "alertProfileParserControl1";
            this.alertProfileParserControl1.Size = new System.Drawing.Size(1100, 767);
            this.alertProfileParserControl1.TabIndex = 0;
            // 
            // tbPatientDemographic
            // 
            this.tbPatientDemographic.Controls.Add(this.patientDemographicControl1);
            this.tbPatientDemographic.Location = new System.Drawing.Point(4, 22);
            this.tbPatientDemographic.Name = "tbPatientDemographic";
            this.tbPatientDemographic.Size = new System.Drawing.Size(1106, 773);
            this.tbPatientDemographic.TabIndex = 2;
            this.tbPatientDemographic.Text = "Patient Demographic";
            this.tbPatientDemographic.UseVisualStyleBackColor = true;
            // 
            // patientDemographicControl1
            // 
            this.patientDemographicControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientDemographicControl1.Location = new System.Drawing.Point(0, 0);
            this.patientDemographicControl1.Name = "patientDemographicControl1";
            this.patientDemographicControl1.Size = new System.Drawing.Size(1106, 773);
            this.patientDemographicControl1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 799);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tbPatientDemographic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MedicationProfileControl medicationProfileControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private AlertProfileParserControl alertProfileParserControl1;
        private System.Windows.Forms.TabPage tbPatientDemographic;
        private PatientDemographicControl patientDemographicControl1;
    }
}