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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.scintilla2 = new ScintillaNET.Scintilla();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(969, 769);
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
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(226, 719);
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
            this.scintilla3.Location = new System.Drawing.Point(4, 260);
            this.scintilla3.Margin = new System.Windows.Forms.Padding(4);
            this.scintilla3.Name = "scintilla3";
            this.scintilla3.Size = new System.Drawing.Size(320, 451);
            this.scintilla3.TabIndex = 10;
            this.scintilla3.Text = "scintilla3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 769);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.scintilla1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(613, 743);
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
            this.scintilla1.Size = new System.Drawing.Size(605, 735);
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
            this.tabPage6.Size = new System.Drawing.Size(613, 743);
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
            this.scintilla2.Size = new System.Drawing.Size(605, 735);
            this.scintilla2.TabIndex = 1;
            this.scintilla2.Text = "scintilla2";
            // 
            // AlertProfileParserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "AlertProfileParserControl";
            this.Size = new System.Drawing.Size(969, 769);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private ScintillaNET.Scintilla scintilla3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.TabPage tabPage6;
        private ScintillaNET.Scintilla scintilla2;
        private System.Windows.Forms.ComboBox cbxHKId;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaHospCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label1;
    }
}
