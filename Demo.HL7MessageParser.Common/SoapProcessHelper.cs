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
    public class SoapProcessHelper
    {
        private const string CONST_XNAME_BODY = "Body";
        private const string CONST_XNAME_RESPONSE = "searchHKPMIPatientByCaseNoResponse";
        private const string CONST_XNAME_PatientDemoEnquiryResult = "PatientDemoEnquiryResult";

        public static PatientDemoEnquiry DoProcess(string caseNumber)
        {
            try
            {
                var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/Soap_Patient.xml");

                XNamespace nsr = "http://schemas.xmlsoap.org/soap/envelope/";
                XNamespace nsr2 = "http://webservice.pas.ha.org.hk/";

                var doc = XElement.Load(file);

                var elBody = XmlHelper.GetElementByXname(doc, nsr, CONST_XNAME_BODY);

                var elResponse = XmlHelper.GetElementByXname(elBody, nsr2, CONST_XNAME_RESPONSE);

                var patientResultXmlElement = XmlHelper.GetElementByElementName(elResponse, CONST_XNAME_PatientDemoEnquiryResult);

                var result = XmlHelper.XmlDeserialize<PatientDemoEnquiry>(patientResultXmlElement.ToString());

                Console.WriteLine(XmlHelper.XmlSerializeToString(result));
                if (result == null)
                {
                    throw new NotSupportedException("deserializ failed");
                }

                return result;
            }
            catch (Exception ex)
            {
                //logger
                throw;
            }
        }

    }
}
