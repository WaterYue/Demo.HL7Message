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
    public partial class HL7MessageParserFormTest : Form
    {
        public HL7MessageParserFormTest()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var parser = new HL7MessageParser_NTEC();
            

        }

        private void HL7MessageParserFormTest_Load(object sender, EventArgs e)
        {
            cbxCaseNumber.DataSource = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
        }
    }
}
