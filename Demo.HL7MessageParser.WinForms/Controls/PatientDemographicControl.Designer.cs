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
            this.cbxCaseNumber = new System.Windows.Forms.ComboBox();
            this.btnCallByProxy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.scintillaReq.Location = new System.Drawing.Point(4, 4);
            this.scintillaReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scintillaReq.Name = "scintillaReq";
            this.scintillaReq.Size = new System.Drawing.Size(397, 354);
            this.scintillaReq.TabIndex = 0;
            this.scintillaReq.Text = "scintilla1";
            // 
            // chxEnableWSAddress
            // 
            this.chxEnableWSAddress.AutoSize = true;
            this.chxEnableWSAddress.Location = new System.Drawing.Point(8, 82);
            this.chxEnableWSAddress.Name = "chxEnableWSAddress";
            this.chxEnableWSAddress.Size = new System.Drawing.Size(123, 17);
            this.chxEnableWSAddress.TabIndex = 14;
            this.chxEnableWSAddress.Text = "WS-Address Header";
            this.chxEnableWSAddress.UseVisualStyleBackColor = true;
            this.chxEnableWSAddress.CheckedChanged += new System.EventHandler(this.chxEnableWSAddress_CheckedChanged);
            // 
            // btnCallByWebReq
            // 
            this.btnCallByWebReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallByWebReq.Location = new System.Drawing.Point(106, 117);
            this.btnCallByWebReq.Name = "btnCallByWebReq";
            this.btnCallByWebReq.Size = new System.Drawing.Size(95, 30);
            this.btnCallByWebReq.TabIndex = 13;
            this.btnCallByWebReq.Text = "WebReqCall";
            this.btnCallByWebReq.UseVisualStyleBackColor = true;
            this.btnCallByWebReq.Click += new System.EventHandler(this.btnCallByWebReq_Click);
            // 
            // cbxCaseNumber
            // 
            this.cbxCaseNumber.FormattingEnabled = true;
            this.cbxCaseNumber.Location = new System.Drawing.Point(8, 48);
            this.cbxCaseNumber.Name = "cbxCaseNumber";
            this.cbxCaseNumber.Size = new System.Drawing.Size(195, 21);
            this.cbxCaseNumber.TabIndex = 9;
            this.cbxCaseNumber.SelectedIndexChanged += new System.EventHandler(this.cbxCaseNumber_SelectedIndexChanged);
            // 
            // btnCallByProxy
            // 
            this.btnCallByProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallByProxy.Location = new System.Drawing.Point(8, 117);
            this.btnCallByProxy.Name = "btnCallByProxy";
            this.btnCallByProxy.Size = new System.Drawing.Size(92, 30);
            this.btnCallByProxy.TabIndex = 8;
            this.btnCallByProxy.Text = "ProxyCall";
            this.btnCallByProxy.UseVisualStyleBackColor = true;
            this.btnCallByProxy.Click += new System.EventHandler(this.btnCallByProxy_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "CaseNumber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tbReq);
            this.tcBottom.Controls.Add(this.tbRes);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            this.tcBottom.Size = new System.Drawing.Size(413, 388);
            this.tcBottom.TabIndex = 0;
            // 
            // tbReq
            // 
            this.tbReq.Controls.Add(this.scintillaReq);
            this.tbReq.Location = new System.Drawing.Point(4, 22);
            this.tbReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbReq.Name = "tbReq";
            this.tbReq.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbReq.Size = new System.Drawing.Size(405, 362);
            this.tbReq.TabIndex = 0;
            this.tbReq.Text = "RequestXml";
            this.tbReq.UseVisualStyleBackColor = true;
            // 
            // tbRes
            // 
            this.tbRes.Controls.Add(this.scintillaRes);
            this.tbRes.Location = new System.Drawing.Point(4, 22);
            this.tbRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRes.Name = "tbRes";
            this.tbRes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRes.Size = new System.Drawing.Size(405, 362);
            this.tbRes.TabIndex = 1;
            this.tbRes.Text = "ResponseXml";
            this.tbRes.UseVisualStyleBackColor = true;
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(4, 4);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(397, 354);
            this.scintillaRes.TabIndex = 1;
            this.scintillaRes.Text = "scintilla2";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.chxEnableWSAddress);
            this.panelLeft.Controls.Add(this.btnCallByWebReq);
            this.panelLeft.Controls.Add(this.cbxCaseNumber);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.btnCallByProxy);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(210, 388);
            this.panelLeft.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcBottom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(210, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 388);
            this.panel1.TabIndex = 4;
            // 
            // PatientDemographicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Name = "PatientDemographicControl";
            this.Size = new System.Drawing.Size(623, 388);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcBottom;
        private System.Windows.Forms.TabPage tbReq;
        private System.Windows.Forms.TabPage tbRes;
        private ScintillaNET.Scintilla scintillaRes;
        private System.Windows.Forms.Button btnCallByWebReq;
        private System.Windows.Forms.CheckBox chxEnableWSAddress;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
    }
}
