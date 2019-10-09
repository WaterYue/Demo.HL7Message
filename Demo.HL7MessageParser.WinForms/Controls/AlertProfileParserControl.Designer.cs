namespace Demo.HL7MessageParser.WinForms
{
    partial class AlertProfileParserControl
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
            this.txtAccessCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxHKId = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaHospCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scintillaReq = new ScintillaNET.Scintilla();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbRes = new System.Windows.Forms.TabPage();
            this.scintillaRes = new ScintillaNET.Scintilla();
            this.scintillaInputParam = new ScintillaNET.Scintilla();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tbReq = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tbRes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tbReq.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccessCode
            // 
            this.txtAccessCode.Location = new System.Drawing.Point(11, 314);
            this.txtAccessCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAccessCode.Name = "txtAccessCode";
            this.txtAccessCode.Size = new System.Drawing.Size(257, 22);
            this.txtAccessCode.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "AccessCode";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxHKId
            // 
            this.cbxHKId.FormattingEnabled = true;
            this.cbxHKId.Location = new System.Drawing.Point(11, 254);
            this.cbxHKId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxHKId.Name = "cbxHKId";
            this.cbxHKId.Size = new System.Drawing.Size(257, 24);
            this.cbxHKId.TabIndex = 19;
            this.cbxHKId.SelectedIndexChanged += new System.EventHandler(this.cbxHKId_SelectedIndexChanged);
            this.cbxHKId.TextChanged += new System.EventHandler(this.cbxHKId_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(137, 345);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 37);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(11, 137);
            this.txtURL.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(257, 22);
            this.txtURL.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "URL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "HKID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaHospCode
            // 
            this.txtPaHospCode.Location = new System.Drawing.Point(11, 196);
            this.txtPaHospCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPaHospCode.Name = "txtPaHospCode";
            this.txtPaHospCode.Size = new System.Drawing.Size(257, 22);
            this.txtPaHospCode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "PaHospCode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(11, 34);
            this.txtClientSecret.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClientSecret.Multiline = true;
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(257, 67);
            this.txtClientSecret.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client_Secret";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scintilla3
            // 
            this.scintillaReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReq.Location = new System.Drawing.Point(3, 3);
            this.scintillaReq.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scintillaReq.Name = "scintilla3";
            this.scintillaReq.Size = new System.Drawing.Size(708, 386);
            this.scintillaReq.TabIndex = 10;
            this.scintillaReq.Text = "scintilla3";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tbReq);
            this.tcMain.Controls.Add(this.tbRes);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(722, 421);
            this.tcMain.TabIndex = 0;
            // 
            // tbRes
            // 
            this.tbRes.Controls.Add(this.scintillaRes);
            this.tbRes.Location = new System.Drawing.Point(4, 25);
            this.tbRes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbRes.Name = "tbRes";
            this.tbRes.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbRes.Size = new System.Drawing.Size(603, 1003);
            this.tbRes.TabIndex = 1;
            this.tbRes.Text = "Response JSON";
            this.tbRes.UseVisualStyleBackColor = true;
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(5, 5);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(593, 993);
            this.scintillaRes.TabIndex = 1;
            this.scintillaRes.Text = "scintilla2";
            // 
            // scintillaInputParam
            // 
            this.scintillaInputParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaInputParam.Location = new System.Drawing.Point(4, 4);
            this.scintillaInputParam.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaInputParam.Name = "scintillaInputParam";
            this.scintillaInputParam.Size = new System.Drawing.Size(605, 792);
            this.scintillaInputParam.TabIndex = 0;
            this.scintillaInputParam.Text = "scintilla1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtAccessCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxHKId);
            this.panel1.Controls.Add(this.txtClientSecret);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.txtPaHospCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 421);
            this.panel1.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tcMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(280, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(722, 421);
            this.panelMain.TabIndex = 4;
            // 
            // tbReq
            // 
            this.tbReq.Controls.Add(this.scintillaReq);
            this.tbReq.Location = new System.Drawing.Point(4, 25);
            this.tbReq.Name = "tbReq";
            this.tbReq.Padding = new System.Windows.Forms.Padding(3);
            this.tbReq.Size = new System.Drawing.Size(714, 392);
            this.tbReq.TabIndex = 2;
            this.tbReq.Text = "ReqXml";
            this.tbReq.UseVisualStyleBackColor = true;
            // 
            // AlertProfileParserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlertProfileParserControl";
            this.Size = new System.Drawing.Size(1002, 421);
            this.tcMain.ResumeLayout(false);
            this.tbRes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tbReq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ScintillaNET.Scintilla scintillaReq;
        private System.Windows.Forms.TabControl tcMain;
        private ScintillaNET.Scintilla scintillaInputParam;
        private System.Windows.Forms.TabPage tbRes;
        private ScintillaNET.Scintilla scintillaRes;
        private System.Windows.Forms.ComboBox cbxHKId;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaHospCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccessCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbReq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
    }
}
