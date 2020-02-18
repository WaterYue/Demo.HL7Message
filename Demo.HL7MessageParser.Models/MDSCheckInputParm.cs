using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Demo.HL7MessageParser.Models
{

    [XmlRoot(ElementName = "inputParm")]
    public class MDSCheckInputParm
    {
        [XmlElement(ElementName = "patientInfo")]
        public MDSCheck_PatientInfo PatientInfo { get; set; }
        [XmlElement(ElementName = "userInfo")]
        public MDSCheck_UserInfo UserInfo { get; set; }
        [XmlElement(ElementName = "patientAllergyProfile")]
        public List<PatientAllergyProfile> PatientAllergyProfile { get; set; }
        [XmlElement(ElementName = "patientAdrProfile")]
        public PatientAdrProfile PatientAdrProfile { get; set; }
        [XmlElement(ElementName = "currentRxDrugProfile")]
        public CurrentRxDrugProfile CurrentRxDrugProfile { get; set; }
        [XmlElement(ElementName = "hasG6pdDeficiency")]
        public string HasG6pdDeficiency { get; set; }
        [XmlElement(ElementName = "hasPregnancy")]
        public string HasPregnancy { get; set; }
        [XmlElement(ElementName = "checkDdim")]
        public string CheckDdim { get; set; }
        [XmlElement(ElementName = "checkDdcm")]
        public string CheckDdcm { get; set; }
        [XmlElement(ElementName = "checkDam")]
        public string CheckDam { get; set; }
        [XmlElement(ElementName = "checkAdr")]
        public string CheckAdr { get; set; }
        [XmlElement(ElementName = "checkDscm")]
        public string CheckDscm { get; set; }
        [XmlElement(ElementName = "checkDrcm")]
        public string CheckDrcm { get; set; }
        [XmlElement(ElementName = "checkDlcm")]
        public string CheckDlcm { get; set; }
        [XmlElement(ElementName = "checkSteroid")]
        public string CheckSteroid { get; set; }
        [XmlElement(ElementName = "callerSourceSystem")]
        public string CallerSourceSystem { get; set; }
        [XmlElement(ElementName = "checkDiscon")]
        public string CheckDiscon { get; set; }
    }

    [XmlRoot(ElementName = "patientInfo")]
    public class MDSCheck_PatientInfo
    {
        [XmlElement(ElementName = "HKID")]
        public string HKID { get; set; }
        [XmlElement(ElementName = "patientKey")]
        public string PatientKey { get; set; }
        [XmlElement(ElementName = "sex")]
        public string Sex { get; set; }
        [XmlElement(ElementName = "ageInDays")]
        public string AgeInDays { get; set; }
        [XmlElement(ElementName = "heightInCM")]
        public string HeightInCM { get; set; }
        [XmlElement(ElementName = "BSAInM2")]
        public string BSAInM2 { get; set; }
        [XmlElement(ElementName = "weightInKG")]
        public string WeightInKG { get; set; }
        [XmlElement(ElementName = "dataUpdated")]
        public string DataUpdated { get; set; }
        [XmlElement(ElementName = "dataWithinValidPeriod")]
        public string DataWithinValidPeriod { get; set; }
    }

    [XmlRoot(ElementName = "userInfo")]
    public class MDSCheck_UserInfo
    {
        [XmlElement(ElementName = "hospCode")]
        public string HospCode { get; set; }
        [XmlElement(ElementName = "pharSpec")]
        public string PharSpec { get; set; }
        [XmlElement(ElementName = "wrkStnID")]
        public string WrkStnID { get; set; }
        [XmlElement(ElementName = "wrkStnType")]
        public string WrkStnType { get; set; }
    }

    [XmlRoot(ElementName = "manifestations")]
    public class Manifestations
    {
        [XmlElement(ElementName = "seqNo")]
        public string SeqNo { get; set; }
        [XmlElement(ElementName = "mDesc")]
        public string MDesc { get; set; }
    }

    [XmlRoot(ElementName = "patientAllergyProfile")]
    public class PatientAllergyProfile
    {
        [XmlElement(ElementName = "allergySeqNo")]
        public string AllergySeqNo { get; set; }
        [XmlElement(ElementName = "allergenCode")]
        public string AllergenCode { get; set; }
        [XmlElement(ElementName = "displayname")]
        public string Displayname { get; set; }
        [XmlElement(ElementName = "ehrLocalDesc")]
        public string EhrLocalDesc { get; set; }
        [XmlElement(ElementName = "aliasname")]
        public string Aliasname { get; set; }
        [XmlElement(ElementName = "salt")]
        public string Salt { get; set; }
        [XmlElement(ElementName = "nameType")]
        public string NameType { get; set; }
        [XmlElement(ElementName = "allergen")]
        public string Allergen { get; set; }
        [XmlElement(ElementName = "allergenType")]
        public string AllergenType { get; set; }
        [XmlElement(ElementName = "certainty")]
        public string Certainty { get; set; }
        [XmlElement(ElementName = "remark")]
        public string Remark { get; set; }
        [XmlElement(ElementName = "sourceSystem")]
        public string SourceSystem { get; set; }
        [XmlElement(ElementName = "createBy")]
        public string CreateBy { get; set; }
        [XmlElement(ElementName = "createUserName")]
        public string CreateUserName { get; set; }
        [XmlElement(ElementName = "createHosp")]
        public string CreateHosp { get; set; }
        [XmlElement(ElementName = "createRank")]
        public string CreateRank { get; set; }
        [XmlElement(ElementName = "createRankDesc")]
        public string CreateRankDesc { get; set; }
        [XmlElement(ElementName = "createDtm")]
        public string CreateDtm { get; set; }
        [XmlElement(ElementName = "updateBy")]
        public string UpdateBy { get; set; }
        [XmlElement(ElementName = "updateUserName")]
        public string UpdateUserName { get; set; }
        [XmlElement(ElementName = "updateHosp")]
        public string UpdateHosp { get; set; }
        [XmlElement(ElementName = "updateRank")]
        public string UpdateRank { get; set; }
        [XmlElement(ElementName = "updateRankDesc")]
        public string UpdateRankDesc { get; set; }
        [XmlElement(ElementName = "updateDtm")]
        public string UpdateDtm { get; set; }
        [XmlElement(ElementName = "manifestations")]
        public List<Manifestations> Manifestations { get; set; }
        [XmlElement(ElementName = "hiclSeqNo")]
        public string HiclSeqNo { get; set; }
        [XmlElement(ElementName = "hicSeqNos")]
        public string HicSeqNos { get; set; }
    }

    [XmlRoot(ElementName = "reactions")]
    public class Reactions
    {
        [XmlElement(ElementName = "seqNo")]
        public string SeqNo { get; set; }
        [XmlElement(ElementName = "rDesc")]
        public string RDesc { get; set; }
        [XmlElement(ElementName = "severCode")]
        public string SeverCode { get; set; }
        [XmlElement(ElementName = "freqCode")]
        public string FreqCode { get; set; }
    }

    [XmlRoot(ElementName = "patientAdrProfile")]
    public class PatientAdrProfile
    {
        [XmlElement(ElementName = "adrSeqNo")]
        public string AdrSeqNo { get; set; }
        [XmlElement(ElementName = "allergenCode")]
        public string AllergenCode { get; set; }
        [XmlElement(ElementName = "displayname")]
        public string Displayname { get; set; }
        [XmlElement(ElementName = "aliasname")]
        public string Aliasname { get; set; }
        [XmlElement(ElementName = "salt")]
        public string Salt { get; set; }
        [XmlElement(ElementName = "nameType")]
        public string NameType { get; set; }
        [XmlElement(ElementName = "adr")]
        public string Adr { get; set; }
        [XmlElement(ElementName = "adrType")]
        public string AdrType { get; set; }
        [XmlElement(ElementName = "severity")]
        public string Severity { get; set; }
        [XmlElement(ElementName = "remark")]
        public string Remark { get; set; }
        [XmlElement(ElementName = "sourceSystem")]
        public string SourceSystem { get; set; }
        [XmlElement(ElementName = "createBy")]
        public string CreateBy { get; set; }
        [XmlElement(ElementName = "createUserName")]
        public string CreateUserName { get; set; }
        [XmlElement(ElementName = "createHosp")]
        public string CreateHosp { get; set; }
        [XmlElement(ElementName = "createRank")]
        public string CreateRank { get; set; }
        [XmlElement(ElementName = "createRankDesc")]
        public string CreateRankDesc { get; set; }
        [XmlElement(ElementName = "createDtm")]
        public string CreateDtm { get; set; }
        [XmlElement(ElementName = "updateBy")]
        public string UpdateBy { get; set; }
        [XmlElement(ElementName = "updateUserName")]
        public string UpdateUserName { get; set; }
        [XmlElement(ElementName = "updateHosp")]
        public string UpdateHosp { get; set; }
        [XmlElement(ElementName = "updateRank")]
        public string UpdateRank { get; set; }
        [XmlElement(ElementName = "updateRankDesc")]
        public string UpdateRankDesc { get; set; }
        [XmlElement(ElementName = "updateDtm")]
        public string UpdateDtm { get; set; }
        [XmlElement(ElementName = "reactions")]
        public List<Reactions> Reactions { get; set; }
        [XmlElement(ElementName = "hiclSeqNo")]
        public string HiclSeqNo { get; set; }
        [XmlElement(ElementName = "hicSeqNos")]
        public string HicSeqNos { get; set; }
    }

    [XmlRoot(ElementName = "currentRxDrugProfile")]
    public class CurrentRxDrugProfile
    {
        [XmlElement(ElementName = "isCapdItem")]
        public string IsCapdItem { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "rGenId")]
        public string RGenId { get; set; }
        [XmlElement(ElementName = "rDfGenId")]
        public string RDfGenId { get; set; }
        [XmlElement(ElementName = "gcnSeqNo")]
        public string GcnSeqNo { get; set; }
        [XmlElement(ElementName = "trueDisplayName")]
        public string TrueDisplayName { get; set; }
        [XmlElement(ElementName = "drugDisplayName")]
        public string DrugDisplayName { get; set; }
        [XmlElement(ElementName = "drugErrorDisplayName")]
        public string DrugErrorDisplayName { get; set; }
        [XmlElement(ElementName = "arrayPos")]
        public string ArrayPos { get; set; }
        [XmlElement(ElementName = "indRow")]
        public string IndRow { get; set; }
        [XmlElement(ElementName = "ordNo")]
        public string OrdNo { get; set; }
        [XmlElement(ElementName = "hospCode")]
        public string HospCode { get; set; }
        [XmlElement(ElementName = "delete")]
        public string Delete { get; set; }
        [XmlElement(ElementName = "salt")]
        public string Salt { get; set; }
        [XmlElement(ElementName = "strength")]
        public string Strength { get; set; }
        [XmlElement(ElementName = "drugDdimDisplayName")]
        public string DrugDdimDisplayName { get; set; }
        [XmlElement(ElementName = "formCode")]
        public string FormCode { get; set; }
        [XmlElement(ElementName = "itemCode")]
        public string ItemCode { get; set; }
        [XmlElement(ElementName = "specRestrict")]
        public string SpecRestrict { get; set; }
        [XmlElement(ElementName = "specInstruct")]
        public string SpecInstruct { get; set; }
        [XmlElement(ElementName = "pharSpec")]
        public string PharSpec { get; set; }
        [XmlElement(ElementName = "dataUpdate")]
        public string DataUpdate { get; set; }
        [XmlElement(ElementName = "ddimDosRelatedCheck")]
        public string DdimDosRelatedCheck { get; set; }
    }

}
