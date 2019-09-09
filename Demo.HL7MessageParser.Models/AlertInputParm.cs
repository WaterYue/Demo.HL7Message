using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Demo.HL7MessageParser.Models
{
    [XmlRoot(ElementName = "patientInfo")]
    public class PatientInfo
    {
        [XmlElement(ElementName = "hkid")]
        public string Hkid { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "dob")]
        public string Dob { get; set; }
        [XmlElement(ElementName = "sex")]
        public string Sex { get; set; }
        [XmlElement(ElementName = "cccode1")]
        public string Cccode1 { get; set; }
        [XmlElement(ElementName = "cccode2")]
        public string Cccode2 { get; set; }
        [XmlElement(ElementName = "cccode3")]
        public string Cccode3 { get; set; }
        [XmlElement(ElementName = "cccode4")]
        public string Cccode4 { get; set; }
        [XmlElement(ElementName = "cccode5")]
        public string Cccode5 { get; set; }
        [XmlElement(ElementName = "cccode6")]
        public string Cccode6 { get; set; }
    }

    [XmlRoot(ElementName = "userInfo")]
    public class UserInfo
    {
        [XmlElement(ElementName = "hospCode")]
        public string HospCode { get; set; }
        [XmlElement(ElementName = "loginId")]
        public string LoginId { get; set; }
    }

    [XmlRoot(ElementName = "sysInfo")]
    public class SysInfo
    {
        [XmlElement(ElementName = "wsId")]
        public string WsId { get; set; }
        [XmlElement(ElementName = "sourceSystem")]
        public string SourceSystem { get; set; }
    }

    [XmlRoot(ElementName = "credentials")]
    public class Credentials
    {
        [XmlElement(ElementName = "accessCode")]
        public string AccessCode { get; set; }
    }

    [XmlRoot(ElementName = "alertInputParm")]
    public class AlertInputParm
    {
        [XmlElement(ElementName = "patientInfo")]
        public PatientInfo PatientInfo { get; set; }

        [XmlElement(ElementName = "userInfo")]
        public UserInfo UserInfo { get; set; }

        [XmlElement(ElementName = "sysInfo")]
        public SysInfo SysInfo { get; set; }

        [XmlElement(ElementName = "credentials")]
        public Credentials Credentials { get; set; }

        //[XmlElement(ElementName = "name")]
        //public string Name { get; set; }
        //[XmlElement(ElementName = "age")]
        //public int Age { get; set; }
    }

}

