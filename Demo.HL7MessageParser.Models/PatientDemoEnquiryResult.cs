using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Demo.HL7MessageParser.Models
{
    [XmlRoot(ElementName = "case")]
    public class Case
    {
        [XmlElement(ElementName = "admissionDatetime")]
        public string AdmissionDatetime { get; set; }
        [XmlElement(ElementName = "bedNo")]
        public string BedNo { get; set; }
        [XmlElement(ElementName = "hospitalCode")]
        public string HospitalCode { get; set; }
        [XmlElement(ElementName = "number")]
        public string Number { get; set; }
        [XmlElement(ElementName = "patientType")]
        public string PatientType { get; set; }
        [XmlElement(ElementName = "sourceCode")]
        public string SourceCode { get; set; }
        [XmlElement(ElementName = "sourceIndicator")]
        public string SourceIndicator { get; set; }
        [XmlElement(ElementName = "specialty")]
        public string Specialty { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "wardClass")]
        public string WardClass { get; set; }
        [XmlElement(ElementName = "wardCode")]
        public string WardCode { get; set; }
    }

    [XmlRoot(ElementName = "caseList")]
    public class CaseList
    {
        [XmlElement(ElementName = "case")]
        public Case Case { get; set; }
    }

    [XmlRoot(ElementName = "address")]
    public class Address
    {
        [XmlElement(ElementName = "building")]
        public string Building { get; set; }
        [XmlElement(ElementName = "districtCode")]
        public string DistrictCode { get; set; }
        [XmlElement(ElementName = "fullEnglishAddress")]
        public string FullEnglishAddress { get; set; }
        [XmlElement(ElementName = "record_id")]
        public string Record_id { get; set; }
        [XmlElement(ElementName = "room")]
        public string Room { get; set; }
    }

    [XmlRoot(ElementName = "patient")]
    public class Patient
    {
        [XmlElement(ElementName = "address")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "CCCode1")]
        public string CCCode1 { get; set; }
        [XmlElement(ElementName = "CCCode2")]
        public string CCCode2 { get; set; }
        [XmlElement(ElementName = "CCCode3")]
        public string CCCode3 { get; set; }
        [XmlElement(ElementName = "chineseName")]
        public string ChineseName { get; set; }
        [XmlElement(ElementName = "confidentialFlag")]
        public string ConfidentialFlag { get; set; }
        [XmlElement(ElementName = "DOB")]
        public string DOB { get; set; }
        [XmlElement(ElementName = "exactDOBFlag")]
        public string ExactDOBFlag { get; set; }
        [XmlElement(ElementName = "HKID")]
        public string HKID { get; set; }
        [XmlElement(ElementName = "hkicSymbol")]
        public string HkicSymbol { get; set; }
        [XmlElement(ElementName = "homePhone")]
        public string HomePhone { get; set; }
        [XmlElement(ElementName = "key")]
        public string Key { get; set; }
        [XmlElement(ElementName = "lastPayCode")]
        public string LastPayCode { get; set; }
        [XmlElement(ElementName = "maritalStatus")]
        public string MaritalStatus { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "officePhone")]
        public string OfficePhone { get; set; }
        [XmlElement(ElementName = "race")]
        public string Race { get; set; }
        [XmlElement(ElementName = "sex")]
        public string Sex { get; set; }
    }

    [XmlRoot(ElementName = "PatientDemoEnquiryResult", Namespace = "")]
    public class PatientDemoEnquiry
    {
        [XmlElement(ElementName = "caseList")]
        public CaseList CaseList { get; set; }
        [XmlElement(ElementName = "patient")]
        public Patient Patient { get; set; }
    }
}

