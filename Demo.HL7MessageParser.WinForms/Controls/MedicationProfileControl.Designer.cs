namespace Demo.HL7MessageParser.WinForms
{
    partial class MedicationProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scintillaRes = new ScintillaNET.Scintilla();
            this.scintillaReqMP = new ScintillaNET.Scintilla();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tcBottom.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCaseNumber
            // 
            this.cbxCaseNumber.FormattingEnabled = true;
            this.cbxCaseNumber.Location = new System.Drawing.Point(4, 267);
            this.cbxCaseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCaseNumber.Name = "cbxCaseNumber";
            this.cbxCaseNumber.Size = new System.Drawing.Size(267, 24);
            this.cbxCaseNumber.TabIndex = 9;
            this.cbxCaseNumber.SelectedIndexChanged += new System.EventHandler(this.cbxCaseNumber_SelectedIndexChanged);
            // 
            // btnSendMedicationProfile
            // 
            this.btnSendMedicationProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMedicationProfile.Location = new System.Drawing.Point(142, 308);
            this.btnSendMedicationProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMedicationProfile.Name = "btnSendMedicationProfile";
            this.btnSendMedicationProfile.Size = new System.Drawing.Size(131, 37);
            this.btnSendMedicationProfile.TabIndex = 8;
            this.btnSendMedicationProfile.Text = "Send";
            this.btnSendMedicationProfile.UseVisualStyleBackColor = true;
            this.btnSendMedicationProfile.Click += new System.EventHandler(this.btnSendMedicationProfile_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(4, 136);
            this.txtURL.Margin = new System.Windows.Forms.Padding(5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(267, 22);
            this.txtURL.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-1, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-1, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "CaseNumber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaHospCode
            // 
            this.txtPaHospCode.Location = new System.Drawing.Point(4, 200);
            this.txtPaHospCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtPaHospCode.Name = "txtPaHospCode";
            this.txtPaHospCode.Size = new System.Drawing.Size(267, 22);
            this.txtPaHospCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-1, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "PaHospCode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(4, 33);
            this.txtClientSecret.Margin = new System.Windows.Forms.Padding(5);
            this.txtClientSecret.Multiline = true;
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(267, 67);
            this.txtClientSecret.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client_Secret";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tabPage4);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Margin = new System.Windows.Forms.Padding(5);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            this.tcBottom.Size = new System.Drawing.Size(590, 394);
            this.tcBottom.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.scintillaRes);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage4.Size = new System.Drawing.Size(582, 365);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Response JSON";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(5, 5);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(5);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(572, 355);
            this.scintillaRes.TabIndex = 1;
            this.scintillaRes.Text = "scintilla2";
            // 
            // scintillaReqMP
            // 
            this.scintillaReqMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReqMP.Location = new System.Drawing.Point(4, 4);
            this.scintillaReqMP.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaReqMP.Name = "scintillaReqMP";
            this.scintillaReqMP.Size = new System.Drawing.Size(675, 685);
            this.scintillaReqMP.TabIndex = 0;
            this.scintillaReqMP.Text = "scintilla1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxCaseNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSendMedicationProfile);
            this.panel1.Controls.Add(this.txtClientSecret);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPaHospCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 394);
            this.panel1.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tcBottom);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(280, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(590, 394);
            this.panelMain.TabIndex = 3;
            // 
            // MedicationProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicationProfileControl";
            this.Size = new System.Drawing.Size(870, 394);
            this.tcBottom.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCaseNumber;
        private System.Windows.Forms.Button btnSendMedicationProfile;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaHospCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcBottom;
        private ScintillaNET.Scintilla scintillaReqMP;
        private System.Windows.Forms.TabPage tabPage4;
        private ScintillaNET.Scintilla scintillaRes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
    }
}
