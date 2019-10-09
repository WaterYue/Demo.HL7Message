namespace Demo.HL7MessageParser.WinForms
{
    partial class PatientDemographicControl
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
            this.scintillaReq = new ScintillaNET.Scintilla();
            this.chxEnableWSAddress = new System.Windows.Forms.CheckBox();
            this.btnCallByWebReq = new System.Windows.Forms.Button();
            this.txtHospitalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCaseNumber = new System.Windows.Forms.ComboBox();
            this.btnCallByProxy = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcBottom = new System.Windows.Forms.TabControl();
            this.tbReq = new System.Windows.Forms.TabPage();
            this.tbRes = new System.Windows.Forms.TabPage();
            this.scintillaRes = new ScintillaNET.Scintilla();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcBottom.SuspendLayout();
            this.tbReq.SuspendLayout();
            this.tbRes.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scintillaReq
            // 
            this.scintillaReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReq.Location = new System.Drawing.Point(5, 5);
            this.scintillaReq.Margin = new System.Windows.Forms.Padding(5);
            this.scintillaReq.Name = "scintillaReq";
            this.scintillaReq.Size = new System.Drawing.Size(533, 438);
            this.scintillaReq.TabIndex = 0;
            this.scintillaReq.Text = "scintilla1";
            // 
            // chxEnableWSAddress
            // 
            this.chxEnableWSAddress.AutoSize = true;
            this.chxEnableWSAddress.Location = new System.Drawing.Point(10, 343);
            this.chxEnableWSAddress.Margin = new System.Windows.Forms.Padding(4);
            this.chxEnableWSAddress.Name = "chxEnableWSAddress";
            this.chxEnableWSAddress.Size = new System.Drawing.Size(160, 21);
            this.chxEnableWSAddress.TabIndex = 14;
            this.chxEnableWSAddress.Text = "WS-Address Header";
            this.chxEnableWSAddress.UseVisualStyleBackColor = true;
            this.chxEnableWSAddress.CheckedChanged += new System.EventHandler(this.chxEnableWSAddress_CheckedChanged);
            // 
            // btnCallByWebReq
            // 
            this.btnCallByWebReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallByWebReq.Location = new System.Drawing.Point(142, 386);
            this.btnCallByWebReq.Margin = new System.Windows.Forms.Padding(4);
            this.btnCallByWebReq.Name = "btnCallByWebReq";
            this.btnCallByWebReq.Size = new System.Drawing.Size(127, 37);
            this.btnCallByWebReq.TabIndex = 13;
            this.btnCallByWebReq.Text = "WebReqCall";
            this.btnCallByWebReq.UseVisualStyleBackColor = true;
            this.btnCallByWebReq.Click += new System.EventHandler(this.btnCallByWebReq_Click);
            // 
            // txtHospitalCode
            // 
            this.txtHospitalCode.Location = new System.Drawing.Point(10, 236);
            this.txtHospitalCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtHospitalCode.Name = "txtHospitalCode";
            this.txtHospitalCode.Size = new System.Drawing.Size(259, 22);
            this.txtHospitalCode.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "PaHospCode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCaseNumber
            // 
            this.cbxCaseNumber.FormattingEnabled = true;
            this.cbxCaseNumber.Location = new System.Drawing.Point(10, 301);
            this.cbxCaseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCaseNumber.Name = "cbxCaseNumber";
            this.cbxCaseNumber.Size = new System.Drawing.Size(259, 24);
            this.cbxCaseNumber.TabIndex = 9;
            this.cbxCaseNumber.SelectedIndexChanged += new System.EventHandler(this.cbxCaseNumber_SelectedIndexChanged);
            // 
            // btnCallByProxy
            // 
            this.btnCallByProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallByProxy.Location = new System.Drawing.Point(10, 386);
            this.btnCallByProxy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCallByProxy.Name = "btnCallByProxy";
            this.btnCallByProxy.Size = new System.Drawing.Size(122, 37);
            this.btnCallByProxy.TabIndex = 8;
            this.btnCallByProxy.Text = "ProxyCall";
            this.btnCallByProxy.UseVisualStyleBackColor = true;
            this.btnCallByProxy.Click += new System.EventHandler(this.btnCallByProxy_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(10, 32);
            this.txtURL.Margin = new System.Windows.Forms.Padding(5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(259, 22);
            this.txtURL.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "CaseNumber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 170);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(5, 138);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 27);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(10, 101);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tbReq);
            this.tcBottom.Controls.Add(this.tbRes);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Margin = new System.Windows.Forms.Padding(5);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            this.tcBottom.Size = new System.Drawing.Size(551, 477);
            this.tcBottom.TabIndex = 0;
            // 
            // tbReq
            // 
            this.tbReq.Controls.Add(this.scintillaReq);
            this.tbReq.Location = new System.Drawing.Point(4, 25);
            this.tbReq.Margin = new System.Windows.Forms.Padding(5);
            this.tbReq.Name = "tbReq";
            this.tbReq.Padding = new System.Windows.Forms.Padding(5);
            this.tbReq.Size = new System.Drawing.Size(543, 448);
            this.tbReq.TabIndex = 0;
            this.tbReq.Text = "RequestXml";
            this.tbReq.UseVisualStyleBackColor = true;
            // 
            // tbRes
            // 
            this.tbRes.Controls.Add(this.scintillaRes);
            this.tbRes.Location = new System.Drawing.Point(4, 25);
            this.tbRes.Margin = new System.Windows.Forms.Padding(5);
            this.tbRes.Name = "tbRes";
            this.tbRes.Padding = new System.Windows.Forms.Padding(5);
            this.tbRes.Size = new System.Drawing.Size(1003, 815);
            this.tbRes.TabIndex = 1;
            this.tbRes.Text = "ResponseXml";
            this.tbRes.UseVisualStyleBackColor = true;
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(5, 5);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(5);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(993, 805);
            this.scintillaRes.TabIndex = 1;
            this.scintillaRes.Text = "scintilla2";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.chxEnableWSAddress);
            this.panelLeft.Controls.Add(this.btnCallByWebReq);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.txtHospitalCode);
            this.panelLeft.Controls.Add(this.txtUserName);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.lblPassword);
            this.panelLeft.Controls.Add(this.txtPassword);
            this.panelLeft.Controls.Add(this.cbxCaseNumber);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.btnCallByProxy);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.txtURL);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 477);
            this.panelLeft.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcBottom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 477);
            this.panel1.TabIndex = 4;
            // 
            // PatientDemographicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientDemographicControl";
            this.Size = new System.Drawing.Size(831, 477);
            this.tcBottom.ResumeLayout(false);
            this.tbReq.ResumeLayout(false);
            this.tbRes.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla scintillaReq;
        private System.Windows.Forms.ComboBox cbxCaseNumber;
        private System.Windows.Forms.Button btnCallByProxy;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcBottom;
        private System.Windows.Forms.TabPage tbReq;
        private System.Windows.Forms.TabPage tbRes;
        private ScintillaNET.Scintilla scintillaRes;
        private System.Windows.Forms.TextBox txtHospitalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCallByWebReq;
        private System.Windows.Forms.CheckBox chxEnableWSAddress;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
    }
}
