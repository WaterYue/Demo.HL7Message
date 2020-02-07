using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rtxt.ReadOnly = true;
            rtxt.Text = "SAFDDDDDDDDDDDDDDDDDDDDDDDDD";
            RefreshAlignment();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtxt.Text = "SAFDDDDDDDDDDDDDDDDDDDDDDDDD";
            RefreshAlignment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtxt.Text += Environment.NewLine;
           rtxt.Text += "SAFDDDDDDDDDDDDDDDDDDDDDDDDD";
        }

        private void rtxt_TextChanged(object sender, EventArgs e)
        {
            RefreshAlignment();
        }

        private void RefreshAlignment()
        {
            rtxt.SelectAll();
            rtxt.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
