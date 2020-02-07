namespace Demo.HL7MessageParser.WinForms
{
    partial class PatientOrderAlertControl
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbxCaseNumber = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scintillaPatient = new ScintillaNET.Scintilla();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.scintillaProfiles = new ScintillaNET.Scintilla();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scintillaAlerts = new ScintillaNET.Scintilla();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(320, 37);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(5);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(95, 35);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Send";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CaseNumber";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbxCaseNumber);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnRequest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1006, 655);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // cbxCaseNumber
            // 
            this.cbxCaseNumber.FormattingEnabled = true;
            this.cbxCaseNumber.Location = new System.Drawing.Point(140, 41);
            this.cbxCaseNumber.Name = "cbxCaseNumber";
            this.cbxCaseNumber.Size = new System.Drawing.Size(150, 28);
            this.cbxCaseNumber.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1006, 551);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scintillaPatient);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PatientDemorgaic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // scintillaPatient
            // 
            this.scintillaPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaPatient.Location = new System.Drawing.Point(3, 3);
            this.scintillaPatient.Name = "scintillaPatient";
            this.scintillaPatient.Size = new System.Drawing.Size(992, 512);
            this.scintillaPatient.TabIndex = 1;
            this.scintillaPatient.Text = "PatientVisit";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.scintillaProfiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MedicationProfile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // scintillaProfiles
            // 
            this.scintillaProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaProfiles.Location = new System.Drawing.Point(3, 3);
            this.scintillaProfiles.Name = "scintillaProfiles";
            this.scintillaProfiles.Size = new System.Drawing.Size(992, 512);
            this.scintillaProfiles.TabIndex = 1;
            this.scintillaProfiles.Text = "Patient Profile";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.scintillaAlerts);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(998, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AlertProfile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // scintillaAlerts
            // 
            this.scintillaAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaAlerts.Location = new System.Drawing.Point(3, 3);
            this.scintillaAlerts.Name = "scintillaAlerts";
            this.scintillaAlerts.Size = new System.Drawing.Size(992, 512);
            this.scintillaAlerts.TabIndex = 0;
            this.scintillaAlerts.Text = "Patient Allergy";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // PatientOrderAlertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PatientOrderAlertControl";
            this.Size = new System.Drawing.Size(1006, 655);
            this.Load += new System.EventHandler(this.HL7MessageParserFormTest_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla scintillaPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbxCaseNumber;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ScintillaNET.Scintilla scintillaProfiles;
        private System.Windows.Forms.TabPage tabPage3;
        private ScintillaNET.Scintilla scintillaAlerts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
