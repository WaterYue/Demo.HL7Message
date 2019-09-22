namespace Demo.HL7MessageParser.WinForms
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMedicationProfile = new System.Windows.Forms.TabPage();
            this.tpAlertProfile = new System.Windows.Forms.TabPage();
            this.tpPatientDemographic = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.scintilla2 = new ScintillaNET.Scintilla();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scintillaResMP = new ScintillaNET.Scintilla();
            this.tcMain.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMedicationProfile);
            this.tcMain.Controls.Add(this.tpAlertProfile);
            this.tcMain.Controls.Add(this.tpPatientDemographic);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1215, 843);
            this.tcMain.TabIndex = 0;
            // 
            // tpMedicationProfile
            // 
            this.tpMedicationProfile.Location = new System.Drawing.Point(4, 22);
            this.tpMedicationProfile.Name = "tpMedicationProfile";
            this.tpMedicationProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicationProfile.Size = new System.Drawing.Size(1207, 817);
            this.tpMedicationProfile.TabIndex = 0;
            this.tpMedicationProfile.Text = "MedicationProfile";
            this.tpMedicationProfile.UseVisualStyleBackColor = true;
            // 
            // tpAlertProfile
            // 
            this.tpAlertProfile.Location = new System.Drawing.Point(4, 22);
            this.tpAlertProfile.Name = "tpAlertProfile";
            this.tpAlertProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlertProfile.Size = new System.Drawing.Size(1207, 762);
            this.tpAlertProfile.TabIndex = 1;
            this.tpAlertProfile.Text = "AlertProfile";
            this.tpAlertProfile.UseVisualStyleBackColor = true;
            // 
            // tpPatientDemographic
            // 
            this.tpPatientDemographic.Location = new System.Drawing.Point(4, 22);
            this.tpPatientDemographic.Name = "tpPatientDemographic";
            this.tpPatientDemographic.Size = new System.Drawing.Size(1207, 762);
            this.tpPatientDemographic.TabIndex = 2;
            this.tpPatientDemographic.Text = "PatientDemographic";
            this.tpPatientDemographic.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.scintilla1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1125, 477);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Request JSON";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // scintilla1
            // 
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.Location = new System.Drawing.Point(4, 4);
            this.scintilla1.Margin = new System.Windows.Forms.Padding(4);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(1117, 469);
            this.scintilla1.TabIndex = 0;
            this.scintilla1.Text = "scintilla1";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.scintilla2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(1125, 480);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Response JSON";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // scintilla2
            // 
            this.scintilla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla2.Location = new System.Drawing.Point(4, 4);
            this.scintilla2.Margin = new System.Windows.Forms.Padding(4);
            this.scintilla2.Name = "scintilla2";
            this.scintilla2.Size = new System.Drawing.Size(1117, 472);
            this.scintilla2.TabIndex = 1;
            this.scintilla2.Text = "scintilla2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1125, 540);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Request JSON";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.scintillaResMP);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1125, 543);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Response JSON";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // scintillaResMP
            // 
            this.scintillaResMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaResMP.Location = new System.Drawing.Point(4, 4);
            this.scintillaResMP.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaResMP.Name = "scintillaResMP";
            this.scintillaResMP.Size = new System.Drawing.Size(1117, 535);
            this.scintillaResMP.TabIndex = 1;
            this.scintillaResMP.Text = "scintilla2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 843);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "HL7Interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMedicationProfile;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ScintillaNET.Scintilla scintillaResMP;
        private System.Windows.Forms.TabPage tpAlertProfile;
        private System.Windows.Forms.TabPage tabPage5;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.TabPage tabPage6;
        private ScintillaNET.Scintilla scintilla2;
        private System.Windows.Forms.TabPage tpPatientDemographic;
    }
}

