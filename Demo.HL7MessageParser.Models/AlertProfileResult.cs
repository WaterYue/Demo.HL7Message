using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.Models
{

    public class AdrProfile
    {
        public string adrSeqNo { get; set; }
        public string aliasName { get; set; }
        public string displayName { get; set; }
        public string drug { get; set; }
        public string drugType { get; set; }
        public List<object> hicSeqno { get; set; }
        public string hiclSeqno { get; set; }
        public string nameType { get; set; }
        public string reaction { get; set; }
        public string remark { get; set; }
        public string salt { get; set; }
        public string severity { get; set; }
        public string severityCode { get; set; }
        public string sourceSystem { get; set; }
        public string textColor { get; set; }
        public string updateBy { get; set; }
        public string updateDtm { get; set; }
        public string updateHospital { get; set; }
        public string updateRankDesc { get; set; }
        public string updateUser { get; set; }
        public string updateUserRank { get; set; }
    }

    public class AlertProfile
    {
        public string alertCode { get; set; }
        public string alertDesc { get; set; }
        public string alertSeqNo { get; set; }
        public string classifiedIndicator { get; set; }
        public string remark { get; set; }
        public string textColor { get; set; }
        public string updateDtm { get; set; }
        public string updateHospital { get; set; }
        public string updateUser { get; set; }
        public string updateUserRank { get; set; }
        public string validFrom { get; set; }
        public string validPeriod { get; set; }
        public string validTo { get; set; }
    }

    public class AllergyProfile
    {
        public string aliasName { get; set; }
        public string allergen { get; set; }
        public string allergenType { get; set; }
        public string allergySeqNo { get; set; }
        public string certainty { get; set; }
        public string certaintyCode { get; set; }
        public string displayName { get; set; }
        public List<object> hicSeqno { get; set; }
        public string hiclSeqno { get; set; }
        public string manifestation { get; set; }
        public string nameType { get; set; }
        public string remark { get; set; }
        public string salt { get; set; }
        public string sourceSystem { get; set; }
        public string textColor { get; set; }
        public string updateBy { get; set; }
        public string updateDtm { get; set; }
        public string updateHospital { get; set; }
        public string updateRankDesc { get; set; }
        public string updateUser { get; set; }
        public string updateUserRank { get; set; }
    }

    public class SimpleDisplayFormat
    {
        public string adrRecord { get; set; }
        public string alertRecord { get; set; }
        public string allergyRecord { get; set; }
    }

    public class AlertProfileResult
    {
        public List<AdrProfile> adrProfile { get; set; }
        public List<AlertProfile> alertProfile { get; set; }
        public List<AllergyProfile> allergyProfile { get; set; }
        public List<object> errorMessage { get; set; }
        public object moePatientSteroidTag { get; set; }
        public List<SimpleDisplayFormat> simpleDisplayFormat { get; set; }
    }
}
/*
 * {
    "adrProfile": [
        {
            "adrSeqNo": "0000004366",
            "aliasName": "",
            "displayName": "ASPIRIN",
            "drug": "ASPIRIN",
            "drugType": "D",
            "hicSeqno": [],
            "hiclSeqno": "1820",
            "nameType": "D",
            "reaction": "Abdominal Pain with Cramps; Others",
            "remark": "~!@#$%^&*()_+`-=][\\}{|;':\",./>?<     \n1234567890\n<RRR\n<?\n< ?\n<\n<RRR>\n<>\nqwertyuiopasdfghjklzxcvbnm\nQWERTYUIOPASDFGHJKLZXCVBNM",
            "salt": "",
            "severity": "Severe",
            "severityCode": "S",
            "sourceSystem": "CMS3",
            "textColor": "#000000",
            "updateBy": "Y2KMED",
            "updateDtm": "27-02-2019 14:30:28",
            "updateHospital": "VH",
            "updateRankDesc": "Analyst Programmer I",
            "updateUser": "AA, FORMAT in IP",
            "updateUserRank": "Analyst Programmer I"
        }
    ],
    "alertProfile": [
        {
            "alertCode": "A0001",
            "alertDesc": "G6PD Deficiency",
            "alertSeqNo": "0000045393",
            "classifiedIndicator": "N",
            "remark": "~!@#$%^&*()_+`-=][}{|;':\",./>?<     \n1234567890\n<RRR\n<?\n< ?\n<\n<RRR>\n<>\nqwertyuiopasdfghjklzxcvbnm\nQWERTYUIOPASDFGHJKLZXCVBNM",
            "textColor": "#000000",
            "updateDtm": "27-02-2019 15:47:07",
            "updateHospital": "VH",
            "updateUser": "AA, FORMAT in IP",
            "updateUserRank": "Analyst Programmer I",
            "validFrom": "",
            "validPeriod": "",
            "validTo": ""
        }
    ],
    "allergyProfile": [
        {
            "aliasName": "",
            "allergen": "METHYLPREDNISOLONE ACEPONATE",
            "allergenType": "D",
            "allergySeqNo": "0000090020",
            "certainty": "Certain",
            "certaintyCode": "C",
            "displayName": "METHYLPREDNISOLONE",
            "hicSeqno": [],
            "hiclSeqno": "12057",
            "manifestation": "Allergic rhinitis; Asthma; Rash",
            "nameType": "D",
            "remark": "Asthma",
            "salt": "ACEPONATE",
            "sourceSystem": "CMS3",
            "textColor": "#000000",
            "updateBy": "Y2KMED",
            "updateDtm": "16-08-2019 17:27:01",
            "updateHospital": "VH",
            "updateRankDesc": "Department Manager (Pharmacy)",
            "updateUser": "AA, FORMAT in IP",
            "updateUserRank": "Department Manager (Pharmacy)"
        }
    ],
    "errorMessage": [],
    "moePatientSteroidTag": null,
    "simpleDisplayFormat": [
        {
            "adrRecord": "1. ASPIRIN",
            "alertRecord": "1. G6PD Deficiency",
            "allergyRecord": "1. METHYLPREDNISOLONE ACEPONATE; 2. ASPIRIN; 3. FEDAC CPD LINCTUS [ACTIFED COMPOUND]; 4. BELZER UW-CSS"
        }
    ]
}
 */
