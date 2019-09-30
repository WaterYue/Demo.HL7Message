using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using Demo.HL7MessageParser.Models;

namespace Demo.HL7MessageParser.Common
{
    public class SoapParserHelper
    {
        private const string CONST_XNAME_BODY = "Body";
        private const string CONST_XNAME_RESPONSE = "searchHKPMIPatientByCaseNoResponse";
        private const string CONST_XNAME_PatientDemoEnquiryResult = "PatientDemoEnquiryResult";
        static List<string> cases = new List<string>
        {
            "HN03191100Y",
            "HN17000256S",
            "HN18001140Y",
            "HN170002512",
            "HN170002520",
        };

        public static PatientDemoEnquiry LoadSamplePatientDemoEnquiry(string caseNumber)
        {
            if (!cases.Contains(caseNumber))
            {
                return null ;
            }

            var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("bin/Data/PE/{0}.xml", caseNumber));

            var doc = XElement.Load(file);

            var patientResultXmlElement = ParserPatientDemoEnquiryElement(doc);

            var result = XmlHelper.XmlDeserialize<PatientDemoEnquiry>(patientResultXmlElement.ToString());

            return result;
        }

        public static string ParserPatientDemoEnquiryElement(string docString)
        {
            using (var sr = new StringReader(docString))
            {
                XElement doc = XElement.Load(sr);

                return ParserPatientDemoEnquiryElement(doc);
            }
        }

        public static string ParserPatientDemoEnquiryElement(XElement doc)
        {
            XNamespace nsr = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace nsr2 = "http://webservice.pas.ha.org.hk/";

            var elBody = XmlHelper.GetElementByXname(doc, nsr, CONST_XNAME_BODY);

            var elResponse = XmlHelper.GetElementByXname(elBody, nsr2, CONST_XNAME_RESPONSE);

            var patientResultXmlElement = XmlHelper.GetElementByElementName(elResponse, CONST_XNAME_PatientDemoEnquiryResult);

            return patientResultXmlElement.ToString();
        }


    }
}
