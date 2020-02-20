using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.HL7MessageParser.WinForms.Lexers;
using Demo.HL7MessageParser.Common;

using Microsoft.Web.Services3.Security.Tokens;
using System.Net;
using System.IO;
using Demo.HL7MessageParser.WebProxy;
using NLog;
using System.Configuration;
using Demo.HL7MessageParser.Models;
using System.Xml.Linq;

namespace Demo.HL7MessageParser.WinForms
{
    public partial class DrugMasterControl : UserControl
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private IHL7MessageParser hl7messageParser;


        static DrugMasterControl()
        {
            reqDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\DM");
        }

        public DrugMasterControl(IHL7MessageParser hl7messageParser)
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                Initialize();
            }

            this.hl7messageParser = hl7messageParser;

            Initialize();
        }
        private static readonly string reqDir;
        private void Initialize()
        {
            txtURL.Text = Global.DrugMasterSoapUrl;
            txtURL.ReadOnly = true;

            txtDrugMasterSoapUrl.Text = Global.DrugMasterSoapUrl;
            txtDrugMasterSoapUrl.ReadOnly = true;

            try
            {
                var files = Directory.GetFiles(Path.Combine(reqDir, @"getDrugMdsPropertyHq\Req"), "*.xml");

                cbxCaseNumber.DataSource = files.Select(o => new FileInfo(o).Name)
                                                .Select(o => o.Substring(0, o.Length - ".xml".Length))
                                                .ToList();



                var files2 = Directory.GetFiles(Path.Combine(reqDir, @"getPreparation\Req"), "*.xml");

                cbxIDrugItemCodes.DataSource = files2.Select(o => new FileInfo(o).Name)
                                                .Select(o => o.Substring(0, o.Length - ".xml".Length))
                                                .ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            scintillaRes.Text = string.Empty;

            try
            {
                var res = hl7messageParser.getDrugMdsPropertyHq(SelectedGetDrugMdsPropertyHqRequest);

                var resStr = XmlHelper.XmlSerializeToString(res);

                scintillaRes.Focus();

                scintillaRes.Text = XmlHelper.FormatXML(resStr);
                scintillaRes.FormatStyle(StyleType.Xml);

            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);

                MessageBox.Show(ex.Message);
            }
        }
        private void cbxCaseNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReqXml();
        }
        GetDrugMdsPropertyHqRequest SelectedGetDrugMdsPropertyHqRequest = null;
        private void GenerateReqXml()
        {
            tcMain.SelectedIndex = 0;
            scintillaReq.Focus();

            try
            {
                var file = Path.Combine(reqDir, string.Format(@"getDrugMdsPropertyHq\Req\{0}.xml", cbxCaseNumber.SelectedItem.ToString()));

                var doc = XDocument.Load(file);

                XNamespace x = "http://schemas.xmlsoap.org/soap/envelope/";
                XNamespace x2 = "http://biz.dms.pms.model.ha.org.hk/";

                var element = doc.Descendants(x + "Body")
                              .Descendants(x2 + "getDrugMdsPropertyHq")
                               .Descendants("arg0").First();

                var arg0 = XmlHelper.XmlDeserialize<GetDrugMdsPropertyHq_Arg0>(element.ToString());

                SelectedGetDrugMdsPropertyHqRequest = new GetDrugMdsPropertyHqRequest { Arg0 = arg0 };

                //   scintillaReq.Text = XmlHelper.FormatXML(XmlHelper.XmlSerializeToString(SelectedGetDrugMdsPropertyHqRequest));

                scintillaReq.Text = XmlHelper.FormatXML(doc.ToString());

                scintillaReq.FormatStyle(StyleType.Xml);
            }
            catch (Exception ex)
            {

            }
        }



        private void btnRequestPreparation_Click(object sender, EventArgs e)
        {

            scintillaResPreparation.Text = string.Empty;

            try
            {
                var res = hl7messageParser.getPreparation(SelectedGetPreparationRequest);

                var resStr = XmlHelper.XmlSerializeToString(res);

                scintillaResPreparation.Focus();

                scintillaResPreparation.Text = XmlHelper.FormatXML(resStr);
                scintillaResPreparation.FormatStyle(StyleType.Xml);

            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);

                MessageBox.Show(ex.Message);
            }

        }

        private void cbxIDrugItemCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReqPreparationXml();
        }

        GetPreparationRequest SelectedGetPreparationRequest = null;
        private void GenerateReqPreparationXml()
        {
            scintillaReqPreparation.Focus();

            try
            {
                var file = Path.Combine(reqDir, string.Format(@"getPreparation\Req\{0}.xml", cbxIDrugItemCodes.SelectedItem.ToString()));

                var doc = XDocument.Load(file);

                XNamespace x = "http://schemas.xmlsoap.org/soap/envelope/";
                XNamespace x2 = "http://biz.dms.pms.model.ha.org.hk/";

                var element = doc.Descendants(x + "Body")
                              .Descendants(x2 + "getPreparation")
                               .Descendants("arg0").First();

                var arg0 = XmlHelper.XmlDeserialize<Arg0>(element.ToString());

                SelectedGetPreparationRequest = new GetPreparationRequest { Arg0 = arg0 };

                scintillaReqPreparation.Text = XmlHelper.FormatXML(doc.ToString());

                scintillaReqPreparation.FormatStyle(StyleType.Xml);
            }
            catch (Exception ex)
            {

            }
        }


    }
}
