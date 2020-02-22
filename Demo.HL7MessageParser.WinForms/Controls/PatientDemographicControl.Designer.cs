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
            this.chxEnableWSAddress = new System.Windows.Forms.CheckBox();
            this.btnCallByWebReq = new System.Windows.Forms.Button();
            this.cbxCaseNumber = new System.Windows.Forms.ComboBox();
            this.btnCallByProxy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerReqRes = new System.Windows.Forms.SplitContainer();
            this.gbxReq = new System.Windows.Forms.GroupBox();
            this.scintillaReq = new ScintillaNET.Scintilla();
            this.gbxRes = new System.Windows.Forms.GroupBox();
            this.scintillaRes = new ScintillaNET.Scintilla();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReqRes)).BeginInit();
            this.splitContainerReqRes.Panel1.SuspendLayout();
            this.splitContainerReqRes.Panel2.SuspendLayout();
            this.splitContainerReqRes.SuspendLayout();
            this.gbxReq.SuspendLayout();
            this.gbxRes.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // chxEnableWSAddress
            // 
            this.chxEnableWSAddress.AutoSize = true;
            this.chxEnableWSAddress.Location = new System.Drawing.Point(341, 39);
            this.chxEnableWSAddress.Name = "chxEnableWSAddress";
            this.chxEnableWSAddress.Size = new System.Drawing.Size(15, 14);
            this.chxEnableWSAddress.TabIndex = 14;
            this.chxEnableWSAddress.UseVisualStyleBackColor = true;
            this.chxEnableWSAddress.CheckedChanged += new System.EventHandler(this.chxEnableWSAddress_CheckedChanged);
            // 
            // btnCallByWebReq
            // 
            this.btnCallByWebReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallByWebReq.Location = new System.Drawing.Point(362, 30);
            this.btnCallByWebReq.Name = "btnCallByWebReq";
            this.btnCallByWebReq.Size = new System.Drawing.Size(111, 29);
            this.btnCallByWebReq.TabIndex = 13;
            this.btnCallByWebReq.Text = "WebReqCall";
            this.btnCallByWebReq.UseVisualStyleBackColor = true;
            this.btnCallByWebReq.Click += new System.EventHandler(this.btnCallByWebReq_Click);
            // 
            // cbxCaseNumber
            // 
            this.cbxCaseNumber.FormattingEnabled = true;
            this.cbxCaseNumber.Location = new System.Drawing.Point(95, 36);
            this.cbxCaseNumber.Name = "cbxCaseNumber";
            this.cbxCaseNumber.Size = new System.Drawing.Size(227, 21);
            this.cbxCaseNumber.TabIndex = 9;
            this.cbxCaseNumber.SelectedIndexChanged += new System.EventHandler(this.cbxCaseNumber_SelectedIndexChanged);
            // 
            // btnCallByProxy
            // 
            this.btnCallByProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallByProxy.Location = new System.Drawing.Point(489, 30);
            this.btnCallByProxy.Name = "btnCallByProxy";
            this.btnCallByProxy.Size = new System.Drawing.Size(111, 29);
            this.btnCallByProxy.TabIndex = 8;
            this.btnCallByProxy.Text = "ProxyCall";
            this.btnCallByProxy.UseVisualStyleBackColor = true;
            this.btnCallByProxy.Click += new System.EventHandler(this.btnCallByProxy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CaseNumber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerReqRes);
            this.panel1.Controls.Add(this.gbxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 678);
            this.panel1.TabIndex = 4;
            // 
            // splitContainerReqRes
            // 
            this.splitContainerReqRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerReqRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerReqRes.Location = new System.Drawing.Point(0, 85);
            this.splitContainerReqRes.Name = "splitContainerReqRes";
            // 
            // splitContainerReqRes.Panel1
            // 
            this.splitContainerReqRes.Panel1.Controls.Add(this.gbxReq);
            // 
            // splitContainerReqRes.Panel2
            // 
            this.splitContainerReqRes.Panel2.Controls.Add(this.gbxRes);
            this.splitContainerReqRes.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerReqRes.Size = new System.Drawing.Size(1101, 593);
            this.splitContainerReqRes.SplitterDistance = 536;
            this.splitContainerReqRes.SplitterWidth = 5;
            this.splitContainerReqRes.TabIndex = 21;
            // 
            // gbxReq
            // 
            this.gbxReq.Controls.Add(this.scintillaReq);
            this.gbxReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxReq.Location = new System.Drawing.Point(0, 0);
            this.gbxReq.Name = "gbxReq";
            this.gbxReq.Size = new System.Drawing.Size(536, 593);
            this.gbxReq.TabIndex = 0;
            this.gbxReq.TabStop = false;
            this.gbxReq.Text = "Request";
            // 
            // scintillaReq
            // 
            this.scintillaReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReq.Location = new System.Drawing.Point(3, 17);
            this.scintillaReq.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scintillaReq.Name = "scintillaReq";
            this.scintillaReq.Size = new System.Drawing.Size(530, 573);
            this.scintillaReq.TabIndex = 10;
            this.scintillaReq.Text = "scintilla3";
            // 
            // gbxRes
            // 
            this.gbxRes.Controls.Add(this.scintillaRes);
            this.gbxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRes.Location = new System.Drawing.Point(0, 0);
            this.gbxRes.Name = "gbxRes";
            this.gbxRes.Size = new System.Drawing.Size(560, 593);
            this.gbxRes.TabIndex = 0;
            this.gbxRes.TabStop = false;
            this.gbxRes.Text = "Response";
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(3, 17);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(554, 573);
            this.scintillaRes.TabIndex = 1;
            this.scintillaRes.Text = "scintilla2";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.cbxCaseNumber);
            this.gbxSearch.Controls.Add(this.label3);
            this.gbxSearch.Controls.Add(this.chxEnableWSAddress);
            this.gbxSearch.Controls.Add(this.btnCallByProxy);
            this.gbxSearch.Controls.Add(this.btnCallByWebReq);
            this.gbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.Location = new System.Drawing.Point(0, 0);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(1101, 85);
            this.gbxSearch.TabIndex = 22;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // PatientDemographicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PatientDemographicControl";
            this.Size = new System.Drawing.Size(1101, 678);
            this.panel1.ResumeLayout(false);
            this.splitContainerReqRes.Panel1.ResumeLayout(false);
            this.splitContainerReqRes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReqRes)).EndInit();
            this.splitContainerReqRes.ResumeLayout(false);
            this.gbxReq.ResumeLayout(false);
            this.gbxRes.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCaseNumber;
        private System.Windows.Forms.Button btnCallByProxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCallByWebReq;
        private System.Windows.Forms.CheckBox chxEnableWSAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerReqRes;
        private System.Windows.Forms.GroupBox gbxReq;
        private ScintillaNET.Scintilla scintillaReq;
        private System.Windows.Forms.GroupBox gbxRes;
        private ScintillaNET.Scintilla scintillaRes;
        private System.Windows.Forms.GroupBox gbxSearch;
    }
}
