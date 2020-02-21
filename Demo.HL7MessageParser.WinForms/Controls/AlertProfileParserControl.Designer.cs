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
            this.cbxHKId = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scintillaReq = new ScintillaNET.Scintilla();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbReq = new System.Windows.Forms.TabPage();
            this.tbRes = new System.Windows.Forms.TabPage();
            this.scintillaRes = new ScintillaNET.Scintilla();
            this.scintillaInputParam = new ScintillaNET.Scintilla();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tcMain.SuspendLayout();
            this.tbReq.SuspendLayout();
            this.tbRes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxHKId
            // 
            this.cbxHKId.FormattingEnabled = true;
            this.cbxHKId.Location = new System.Drawing.Point(6, 47);
            this.cbxHKId.Name = "cbxHKId";
            this.cbxHKId.Size = new System.Drawing.Size(194, 21);
            this.cbxHKId.TabIndex = 19;
            this.cbxHKId.SelectedIndexChanged += new System.EventHandler(this.cbxHKId_SelectedIndexChanged);
            this.cbxHKId.TextChanged += new System.EventHandler(this.cbxHKId_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(101, 121);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 30);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "HKID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scintillaReq
            // 
            this.scintillaReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReq.Location = new System.Drawing.Point(2, 2);
            this.scintillaReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scintillaReq.Name = "scintillaReq";
            this.scintillaReq.Size = new System.Drawing.Size(530, 312);
            this.scintillaReq.TabIndex = 10;
            this.scintillaReq.Text = "scintilla3";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tbReq);
            this.tcMain.Controls.Add(this.tbRes);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(542, 342);
            this.tcMain.TabIndex = 0;
            // 
            // tbReq
            // 
            this.tbReq.Controls.Add(this.scintillaReq);
            this.tbReq.Location = new System.Drawing.Point(4, 22);
            this.tbReq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbReq.Name = "tbReq";
            this.tbReq.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbReq.Size = new System.Drawing.Size(534, 316);
            this.tbReq.TabIndex = 2;
            this.tbReq.Text = "ReqXml";
            this.tbReq.UseVisualStyleBackColor = true;
            // 
            // tbRes
            // 
            this.tbRes.Controls.Add(this.scintillaRes);
            this.tbRes.Location = new System.Drawing.Point(4, 22);
            this.tbRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRes.Name = "tbRes";
            this.tbRes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRes.Size = new System.Drawing.Size(534, 316);
            this.tbRes.TabIndex = 1;
            this.tbRes.Text = "Response JSON";
            this.tbRes.UseVisualStyleBackColor = true;
            // 
            // scintillaRes
            // 
            this.scintillaRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaRes.Location = new System.Drawing.Point(4, 4);
            this.scintillaRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scintillaRes.Name = "scintillaRes";
            this.scintillaRes.Size = new System.Drawing.Size(526, 308);
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
            this.panel1.Controls.Add(this.cbxHKId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 342);
            this.panel1.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tcMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(210, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(542, 342);
            this.panelMain.TabIndex = 4;
            // 
            // AlertProfileParserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "AlertProfileParserControl";
            this.Size = new System.Drawing.Size(752, 342);
            this.tcMain.ResumeLayout(false);
            this.tbReq.ResumeLayout(false);
            this.tbRes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbReq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
    }
}
