using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace Demo.HL7MessageParser.ServiceSimulator
{
    [MessageContract(WrapperNamespace = "http://webservice.pas.ha.org.hk/")]
    public class searchHKPMIPatientByCaseNo
    {
        [MessageBodyMember]
        public string hospitalCode { get; set; }
        [MessageBodyMember]
        public string caseNo { get; set; }
    }

    [MessageContract]
    public class SearchHKPMIPatientByCaseNoResponseContract
    {
        [MessageHeader]
        public string WorkContext { get; set; }

        [MessageBodyMember]
        public SearchHKPMIPatientByCaseNoResponse SearchHKPMIPatientByCaseNoResponse { get; set; }
    }

    [DataContract]
    public class Case
    {
        [DataMember]
        public string AdmissionDatetime { get; set; }
        [DataMember]
        public string BedNo { get; set; }
        [DataMember]
        public string HospitalCode { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string PatientType { get; set; }
        [DataMember]
        public string SourceCode { get; set; }
        [DataMember]
        public string SourceIndicator { get; set; }
        [DataMember]
        public string Specialty { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string WardClass { get; set; }
        [DataMember]
        public string WardCode { get; set; }
    }
    [DataContract]
    public class CaseList
    {
        [DataMember]
        public Case Case { get; set; }
    }

    [DataContract]
    public class Address
    {
        [DataMember]
        public string Building { get; set; }
        [DataMember]
        public string DistrictCode { get; set; }
        [DataMember]
        public string FullEnglishAddress { get; set; }
        [DataMember]
        public string Record_id { get; set; }
        [DataMember]
        public string Room { get; set; }

    }

    [DataContract]
    public class Patient
    {
        [DataMember]
        public Address Address { get; set; }
        [DataMember]
        public string CCCode1 { get; set; }
        [DataMember]
        public string CCCode2 { get; set; }
        [DataMember]
        public string CCCode3 { get; set; }
        [DataMember]
        public string ChineseName { get; set; }
        [DataMember]
        public string ConfidentialFlag { get; set; }
        [DataMember]
        public string DOB { get; set; }
        [DataMember]
        public string ExactDOBFlag { get; set; }
        [DataMember]
        public string HKID { get; set; }
        [DataMember]
        public string HkicSymbol { get; set; }
        [DataMember]
        public string HomePhone { get; set; }
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public string LastPayCode { get; set; }
        [DataMember]
        public string MaritalStatus { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string OfficePhone { get; set; }
        [DataMember]
        public string Race { get; set; }
        [DataMember]
        public string Sex { get; set; }
    }

    [DataContract]
    public class PatientDemoEnquiryResult
    {
        [DataMember]
        public CaseList CaseList { get; set; }
        [DataMember]
        public Patient Patient { get; set; }
    }
    [DataContract]
    public class SearchHKPMIPatientByCaseNoResponse
    {
        [DataMember]
        public PatientDemoEnquiryResult PatientDemoEnquiryResult { get; set; }
    }
}