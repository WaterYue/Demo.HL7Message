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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbxCaseNumber = new System.Windows.Forms.ComboBox();
            this.btnSendMedicationProfile = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaHospCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcBottom = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scintillaReqMP = new ScintillaNET.Scintilla();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scintillaResMP = new ScintillaNET.Scintilla();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcBottom.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1149, 812);
            this.tcMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1141, 783);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MedicationProfile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbxCaseNumber);
            this.splitContainer1.Panel1.Controls.Add(this.btnSendMedicationProfile);
            this.splitContainer1.Panel1.Controls.Add(this.txtURL);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPaHospCode);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtClientSecret);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcBottom);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 775);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbxCaseNumber
            // 
            this.cbxCaseNumber.FormattingEnabled = true;
            this.cbxCaseNumber.Location = new System.Drawing.Point(134, 154);
            this.cbxCaseNumber.Name = "cbxCaseNumber";
            this.cbxCaseNumber.Size = new System.Drawing.Size(245, 28);
            this.cbxCaseNumber.TabIndex = 9;
            // 
            // btnSendMedicationProfile
            // 
            this.btnSendMedicationProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMedicationProfile.Location = new System.Drawing.Point(398, 118);
            this.btnSendMedicationProfile.Name = "btnSendMedicationProfile";
            this.btnSendMedicationProfile.Size = new System.Drawing.Size(98, 64);
            this.btnSendMedicationProfile.TabIndex = 8;
            this.btnSendMedicationProfile.Text = "Send";
            this.btnSendMedicationProfile.UseVisualStyleBackColor = true;
            this.btnSendMedicationProfile.Click += new System.EventHandler(this.btnSendMedicationProfile_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(135, 18);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(361, 26);
            this.txtURL.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "CaseNumber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPaHospCode
            // 
            this.txtPaHospCode.Location = new System.Drawing.Point(135, 118);
            this.txtPaHospCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaHospCode.Name = "txtPaHospCode";
            this.txtPaHospCode.Size = new System.Drawing.Size(244, 26);
            this.txtPaHospCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "paHospCode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(135, 54);
            this.txtClientSecret.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientSecret.Multiline = true;
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(361, 55);
            this.txtClientSecret.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client_Secret";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tabPage3);
            this.tcBottom.Controls.Add(this.tabPage4);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Margin = new System.Windows.Forms.Padding(4);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            this.tcBottom.Size = new System.Drawing.Size(1133, 569);
            this.tcBottom.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.scintillaReqMP);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1125, 540);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Request JSON";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // scintillaReqMP
            // 
            this.scintillaReqMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReqMP.Location = new System.Drawing.Point(4, 4);
            this.scintillaReqMP.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaReqMP.Name = "scintillaReqMP";
            this.scintillaReqMP.Size = new System.Drawing.Size(1117, 532);
            this.scintillaReqMP.TabIndex = 0;
            this.scintillaReqMP.Text = "scintilla1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.scintillaResMP);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1259, 569);
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
            this.scintillaResMP.Size = new System.Drawing.Size(1251, 561);
            this.scintillaResMP.TabIndex = 1;
            this.scintillaResMP.Text = "scintilla2";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1275, 783);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AlertProfile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 812);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "HL7Interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcBottom.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tcBottom;
        private System.Windows.Forms.TabPage tabPage3;
        private ScintillaNET.Scintilla scintillaReqMP;
        private System.Windows.Forms.TabPage tabPage4;
        private ScintillaNET.Scintilla scintillaResMP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendMedicationProfile;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaHospCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCaseNumber;
    }
}

