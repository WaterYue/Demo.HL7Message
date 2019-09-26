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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cbxHKId = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaHospCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scintilla3 = new ScintillaNET.Scintilla();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.scintillaInputParam = new ScintillaNET.Scintilla();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.scintillaRes = new ScintillaNET.Scintilla();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccessCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtAccessCode);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.cbxHKId);
            this.splitContainer2.Panel1.Controls.Add(this.btnSend);
            this.splitContainer2.Panel1.Controls.Add(this.txtURL);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.txtPaHospCode);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.txtClientSecret);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.scintilla3);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tcMain);
            this.splitContainer2.Size = new System.Drawing.Size(969, 826);
            this.splitContainer2.SplitterDistance = 343;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 2;
            // 
            // cbxHKId
            // 
            this.cbxHKId.FormattingEnabled = true;
            this.cbxHKId.Location = new System.Drawing.Point(8, 216);
            this.cbxHKId.Name = "cbxHKId";
            this.cbxHKId.Size = new System.Drawing.Size(320, 28);
            this.cbxHKId.TabIndex = 19;
            this.cbxHKId.SelectedIndexChanged += new System.EventHandler(this.cbxHKId_SelectedIndexChanged);
            this.cbxHKId.TextChanged += new System.EventHandler(this.cbxHKId_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(226, 776);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 30);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(8, 110);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(320, 26);
            this.txtURL.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "URL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "HKID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaHospCode
            // 
            this.txtPaHospCode.Location = new System.Drawing.Point(8, 162);
            this.txtPaHospCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaHospCode.Name = "txtPaHospCode";
            this.txtPaHospCode.Size = new System.Drawing.Size(320, 26);
            this.txtPaHospCode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "PaHospCode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(8, 26);
            this.txtClientSecret.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientSecret.Multiline = true;
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(320, 55);
            this.txtClientSecret.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client_Secret";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scintilla3
            // 
            this.scintilla3.Location = new System.Drawing.Point(4, 317);
            this.scintilla3.Margin = new System.Windows.Forms.Padding(4);
            this.scintilla3.Name = "scintilla3";
            this.scintilla3.Size = new System.Drawing.Size(320, 451);
            this.scintilla3.TabIndex = 10;
            this.scintilla3.Text = "scintilla3";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage6);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(621, 826);
            this.tcMain.TabIndex = 0;
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
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.scintillaRes);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(613, 743);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Response JSON";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(4, 4);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(4);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(605, 735);
            this.scintillaRes.TabIndex = 1;
            this.scintillaRes.Text = "scintilla2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "AccessCode";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAccessCode
            // 
            this.txtAccessCode.Location = new System.Drawing.Point(8, 270);
            this.txtAccessCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccessCode.Name = "txtAccessCode";
            this.txtAccessCode.Size = new System.Drawing.Size(320, 26);
            this.txtAccessCode.TabIndex = 21;
            // 
            // AlertProfileParserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "AlertProfileParserControl";
            this.Size = new System.Drawing.Size(969, 826);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private ScintillaNET.Scintilla scintilla3;
        private System.Windows.Forms.TabControl tcMain;
        private ScintillaNET.Scintilla scintillaInputParam;
        private System.Windows.Forms.TabPage tabPage6;
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
    }
}
