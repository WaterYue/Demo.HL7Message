namespace Demo.HL7MessageParser.WinForms
{
    partial class DrugMasterControl
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbReq = new System.Windows.Forms.TabPage();
            this.gbxResponse = new System.Windows.Forms.GroupBox();
            this.scintillaRes = new ScintillaNET.Scintilla();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCaseNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnCallByWebReq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scintillaResPreparation = new ScintillaNET.Scintilla();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scintillaReqPreparation = new ScintillaNET.Scintilla();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxIDrugItemCodes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrugMasterSoapUrl = new System.Windows.Forms.TextBox();
            this.btnRequestPreparation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tbReq.SuspendLayout();
            this.gbxResponse.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbRes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scintillaReq
            // 
            this.scintillaReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReq.Location = new System.Drawing.Point(0, 74);
            this.scintillaReq.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaReq.Name = "scintillaReq";
            this.scintillaReq.Size = new System.Drawing.Size(948, 289);
            this.scintillaReq.TabIndex = 0;
            this.scintillaReq.Text = "scintillaReq";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tbReq);
            this.tcMain.Controls.Add(this.tbRes);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(964, 797);
            this.tcMain.TabIndex = 0;
            // 
            // tbReq
            // 
            this.tbReq.Controls.Add(this.gbxResponse);
            this.tbReq.Controls.Add(this.panelTop);
            this.tbReq.Location = new System.Drawing.Point(4, 22);
            this.tbReq.Margin = new System.Windows.Forms.Padding(4);
            this.tbReq.Name = "tbReq";
            this.tbReq.Padding = new System.Windows.Forms.Padding(4);
            this.tbReq.Size = new System.Drawing.Size(956, 771);
            this.tbReq.TabIndex = 0;
            this.tbReq.Text = "getDrugMdsPropertyHq";
            this.tbReq.UseVisualStyleBackColor = true;
            // 
            // gbxResponse
            // 
            this.gbxResponse.Controls.Add(this.scintillaRes);
            this.gbxResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxResponse.Location = new System.Drawing.Point(4, 367);
            this.gbxResponse.Name = "gbxResponse";
            this.gbxResponse.Size = new System.Drawing.Size(948, 400);
            this.gbxResponse.TabIndex = 2;
            this.gbxResponse.TabStop = false;
            this.gbxResponse.Text = "Response";
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(3, 16);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(942, 381);
            this.scintillaRes.TabIndex = 1;
            this.scintillaRes.Text = "scintillaRes";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.scintillaReq);
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(948, 363);
            this.panelTop.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCaseNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.btnCallByWebReq);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbxCaseNumber
            // 
            this.cbxCaseNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaseNumber.FormattingEnabled = true;
            this.cbxCaseNumber.Location = new System.Drawing.Point(353, 35);
            this.cbxCaseNumber.Name = "cbxCaseNumber";
            this.cbxCaseNumber.Size = new System.Drawing.Size(195, 21);
            this.cbxCaseNumber.TabIndex = 16;
            this.cbxCaseNumber.SelectedIndexChanged += new System.EventHandler(this.cbxCaseNumber_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CaseNumber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(25, 34);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(288, 20);
            this.txtURL.TabIndex = 9;
            // 
            // btnCallByWebReq
            // 
            this.btnCallByWebReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallByWebReq.Location = new System.Drawing.Point(593, 28);
            this.btnCallByWebReq.Name = "btnCallByWebReq";
            this.btnCallByWebReq.Size = new System.Drawing.Size(95, 30);
            this.btnCallByWebReq.TabIndex = 14;
            this.btnCallByWebReq.Text = "Request";
            this.btnCallByWebReq.UseVisualStyleBackColor = true;
            this.btnCallByWebReq.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRes
            // 
            this.tbRes.Controls.Add(this.groupBox3);
            this.tbRes.Controls.Add(this.panel1);
            this.tbRes.Location = new System.Drawing.Point(4, 22);
            this.tbRes.Margin = new System.Windows.Forms.Padding(4);
            this.tbRes.Name = "tbRes";
            this.tbRes.Padding = new System.Windows.Forms.Padding(4);
            this.tbRes.Size = new System.Drawing.Size(956, 771);
            this.tbRes.TabIndex = 1;
            this.tbRes.Text = "getPreparation";
            this.tbRes.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scintillaResPreparation);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(948, 400);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Response";
            // 
            // scintillaResPreparation
            // 
            this.scintillaResPreparation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaResPreparation.Location = new System.Drawing.Point(3, 16);
            this.scintillaResPreparation.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaResPreparation.Name = "scintillaResPreparation";
            this.scintillaResPreparation.Size = new System.Drawing.Size(942, 381);
            this.scintillaResPreparation.TabIndex = 1;
            this.scintillaResPreparation.Text = "scintillaResPreparation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scintillaReqPreparation);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 363);
            this.panel1.TabIndex = 2;
            // 
            // scintillaReqPreparation
            // 
            this.scintillaReqPreparation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReqPreparation.Location = new System.Drawing.Point(0, 74);
            this.scintillaReqPreparation.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaReqPreparation.Name = "scintillaReqPreparation";
            this.scintillaReqPreparation.Size = new System.Drawing.Size(948, 289);
            this.scintillaReqPreparation.TabIndex = 0;
            this.scintillaReqPreparation.Text = "scintillaReqPreparation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxIDrugItemCodes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDrugMasterSoapUrl);
            this.groupBox2.Controls.Add(this.btnRequestPreparation);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 74);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cbxIDrugItemCodes
            // 
            this.cbxIDrugItemCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDrugItemCodes.FormattingEnabled = true;
            this.cbxIDrugItemCodes.Location = new System.Drawing.Point(353, 35);
            this.cbxIDrugItemCodes.Name = "cbxIDrugItemCodes";
            this.cbxIDrugItemCodes.Size = new System.Drawing.Size(195, 21);
            this.cbxIDrugItemCodes.TabIndex = 16;
            this.cbxIDrugItemCodes.SelectedIndexChanged += new System.EventHandler(this.cbxIDrugItemCodes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "CaseNumber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDrugMasterSoapUrl
            // 
            this.txtDrugMasterSoapUrl.Location = new System.Drawing.Point(25, 34);
            this.txtDrugMasterSoapUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrugMasterSoapUrl.Name = "txtDrugMasterSoapUrl";
            this.txtDrugMasterSoapUrl.Size = new System.Drawing.Size(288, 20);
            this.txtDrugMasterSoapUrl.TabIndex = 9;
            // 
            // btnRequestPreparation
            // 
            this.btnRequestPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestPreparation.Location = new System.Drawing.Point(593, 28);
            this.btnRequestPreparation.Name = "btnRequestPreparation";
            this.btnRequestPreparation.Size = new System.Drawing.Size(95, 30);
            this.btnRequestPreparation.TabIndex = 14;
            this.btnRequestPreparation.Text = "Request";
            this.btnRequestPreparation.UseVisualStyleBackColor = true;
            this.btnRequestPreparation.Click += new System.EventHandler(this.btnRequestPreparation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "URL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrugMasterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Name = "DrugMasterControl";
            this.Size = new System.Drawing.Size(964, 797);
            this.tcMain.ResumeLayout(false);
            this.tbReq.ResumeLayout(false);
            this.gbxResponse.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbRes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla scintillaReq;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tbReq;
        private System.Windows.Forms.TabPage tbRes;
        private System.Windows.Forms.GroupBox gbxResponse;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCallByWebReq;
        private ScintillaNET.Scintilla scintillaRes;
        private System.Windows.Forms.ComboBox cbxCaseNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private ScintillaNET.Scintilla scintillaResPreparation;
        private System.Windows.Forms.Panel panel1;
        private ScintillaNET.Scintilla scintillaReqPreparation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxIDrugItemCodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrugMasterSoapUrl;
        private System.Windows.Forms.Button btnRequestPreparation;
        private System.Windows.Forms.Label label2;
    }
}
