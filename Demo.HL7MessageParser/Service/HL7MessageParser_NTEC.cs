using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Demo.HL7MessageParser
{
    public class HL7MessageParser_NTEC : IHL7MessageParser
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private string RestUrl;

        private string SoapUrl;

        private string UserName;
        private string Password;

        private string ClientSecret;
        private string ClientId;

        private string HospitalCode;
        private string AccessCode;

        private string DrugMasterSoapUrl;
        private string MDSCheckRestUrl;
        private IPatientVisitParser patientVisitParser;
        private IProfileRestService profileService;
        private IDrugMasterSoapService drugMasterSoapService;
        private IMDSCheckRestService mdsCheckRestService;

        public HL7MessageParser_NTEC()
        {
            Initialize();

            patientVisitParser = new SoapPatientVisitParser(SoapUrl, UserName, Password, HospitalCode);

            profileService = new ProfileRestService(RestUrl, ClientSecret, ClientId, HospitalCode);

            drugMasterSoapService = new DrugMasterSoapService(DrugMasterSoapUrl);

            mdsCheckRestService = new MDSCheckRestService(MDSCheckRestUrl);

        }

        private void Initialize()
        {
            //TODO Initialize parameters from DB

            SoapUrl = "http://localhost:8096/PatientService.asmx";
            UserName = "pas-appt-ws-user";
            Password = "pas-appt-ws-user-pwd";


            RestUrl = "http://localhost:8290/pms-asa/1/";
            ClientSecret = "CLIENT_SECRET";
            ClientId = "AccessCenter";

            AccessCode = "AccessCode";
            HospitalCode = "VH";

            DrugMasterSoapUrl = "http://localhost:44368/DrugMasterService.asmx";

            MDSCheckRestUrl = "http://localhost:3181/pms-asa/1/";
        }

        public HL7MessageParser_NTEC(IPatientVisitParser patientVisitParser,
                                     IProfileRestService profileService,
                                     IDrugMasterSoapService drugMasterSoapService,
                                     IMDSCheckRestService mdsCheckRestService)
        {
            this.patientVisitParser = patientVisitParser;
            this.profileService = profileService;
            this.drugMasterSoapService = drugMasterSoapService;
            this.mdsCheckRestService = mdsCheckRestService;
        }
        static int Max_Retry_Count = 3;
        private static T GetFuncWithRetry<T>(Func<T> func) where T : class
        {
            int retryCount = 1;

            while (true)
            {
                try
                {
                    return func();
                }
                catch
                {
                    retryCount++;

                    if (retryCount > Max_Retry_Count)
                    {
                        throw;
                    }

                    Thread.Sleep(100);
                }
            }
        }

        public MedicationProfileResult GetMedicationProfiles(string caseno)
        {
            return GetFuncWithRetry<MedicationProfileResult>(() =>
            {
                var medicationProfile = profileService.GetMedicationProfile(caseno);

                logger.Info(JsonHelper.ToJson(medicationProfile));

                return medicationProfile;
            });
        }

        public PatientDemoEnquiry GetPatientEnquiry(string caseno)
        {
            try
            {
                return GetFuncWithRetry<PatientDemoEnquiry>(() =>
                {
                    var pr = patientVisitParser.GetPatientResult(caseno);

                    logger.Info(XmlHelper.XmlSerializeToString(pr));

                    //TODO: storage the response Postponse

                    //var patientVisit = pr.ToConvert();

                    //TODO: storage accesscenter business object to db            


                    return pr;
                });
            }
            catch (AMException amex)
            {
                logger.Error(amex);

                throw amex;
            }
            catch (Exception ex)
            {
                logger.Error(ex);

                throw ex;
            }
        }

        public AlertProfileResult GetAlertProfiles(AlertInputParm alertinput)
        {
            return GetFuncWithRetry<AlertProfileResult>(() =>
            {
                alertinput.Credentials.AccessCode = AccessCode;

                var apr = profileService.GetAlertProfile(alertinput);

                logger.Info(JsonHelper.ToJson(apr));
                //TODO:storage the response

                // var result = apr.ToConvert();

                return apr;
            });
        }

        public GetDrugMdsPropertyHqResponse getDrugMdsPropertyHq(GetDrugMdsPropertyHqRequest request)
        {
            return drugMasterSoapService.getDrugMdsPropertyHq(request);
        }

        public GetPreparationResponse getPreparation(GetPreparationRequest request)
        {
            return drugMasterSoapService.getPreparation(request);
        }

        public MDSCheckResult CheckMDS(MDSCheckInputParm inputParam)
        {
            return mdsCheckRestService.CheckMDS(inputParam);
        }

        public string SaveRemoteHL7PatientToLocal(string caseNumber, out string errorMessage)
        {
            errorMessage = string.Empty;

            var actualProfile = profileService.GetAlertProfile(new Models.AlertInputParm
            {
                PatientInfo = new Models.PatientInfo { Hkid = caseNumber },
                Credentials = new Models.Credentials { AccessCode = AccessCode }
            });

            if (IsInvalidAccessCode(actualProfile))
            {
            }
            return null;
        }

        private static bool IsInvalidAccessCode(AlertProfileResult actualProfile)
        {
            return actualProfile.ErrorMessage.Count > 0 && "20083".Equals(actualProfile.ErrorMessage[0].MsgCode);
        }


        public void CheckDrugClass(PatientDemoEnquiry patientEnquiry, AlertProfileResult alertProfileRes, GetDrugMdsPropertyHqResponse getDrugMdsPropertyHqRes, GetPreparationResponse getPreparationRes)
        {
            var mdsCheckObj = new MDSCheckInputParm
            {
                HasPregnancy = "false",
                CallerSourceSystem = "PMS",
                CheckDiscon = "false"
            };

            var patientInfo = new MDSCheck_PatientInfo
            {
                HKID = patientEnquiry.Patient.HKID,
                PatientKey = patientEnquiry.Patient.Key,
                Sex = patientEnquiry.Patient.Sex,
                //Number of days between Current Date and Patient DOB  \\TODO-JERIFFE: CONFIRM THE AgeInDats Type
                AgeInDays = (DateTime.Now - patientEnquiry.Patient.DOB.ToDateTime()).TotalDays.ToString(),
                HeightInCM = "0",
                BSAInM2 = "0",
                WeightInKG = "0",
                DataUpdated = "N",
                DataWithinValidPeriod = "N"
            };

            var userInfo = new MDSCheck_UserInfo
            {
                HospCode = HospitalCode,
                PharSpec = patientEnquiry.CaseList[0].Specialty,
                WrkStnID = "IP Address",
                WrkStnType = "I"
            };

            foreach (var profile in alertProfileRes.AllergyProfile)
            {
                var allergyProfile = new PatientAllergyProfile
                {
                    AllergySeqNo = profile.AllergySeqNo,
                    AllergenCode = "",
                    Displayname = profile.DisplayName,
                };
            }


            foreach (var profile in alertProfileRes.AdrProfile)
            {
                var allergyProfile = new PatientAdrProfile
                {
                    AdrSeqNo = profile.AdrSeqNo,
                    AllergenCode = "",
                    Displayname = profile.DisplayName,
                    Aliasname = profile.AliasName,
                };
            }

            var currentRxDrugProfile = new CurrentRxDrugProfile
            {
                IsCapdItem = "false",
                TrueDisplayName = getDrugMdsPropertyHqRes.Return[0].DrugProperty.Displayname,
                ArrayPos = "0",
                IndRow = "0",

                OrdNo = "0",
                HospCode = HospitalCode,
                Delete = "false",
                Salt = getDrugMdsPropertyHqRes.Return[0].DrugProperty.SaltProperty,
                FormCode = getDrugMdsPropertyHqRes.Return[0].DrugProperty.FormCode,
                ItemCode = getDrugMdsPropertyHqRes.Return[0].ItemCode,
                Strength = getPreparationRes.Return.Strength,
                SpecRestrict = "",
                SpecInstruct = "",
                PharSpec = "",
                DataUpdate = "N",
                DdimDosRelatedCheck = "N"
            };

        }
    }
}
/*MDS Check Service 
 <inputParm>
    <patientInfo>
        <!-- HN130005510 -->
        <HKID>I001362A</HKID>
        <patientKey>92621099</patientKey>
        <sex>M</sex>
        <ageInDays>6098</ageInDays>
        <heightInCM>0</heightInCM>
        <BSAInM2>0</BSAInM2>
        <weightInKG>0</weightInKG>
        <dataUpdated>N</dataUpdated>
        <dataWithinValidPeriod>N</dataWithinValidPeriod>
    </patientInfo>
    <userInfo>
        <hospCode>VH</hospCode>
        <pharSpec>MED</pharSpec>
        <wrkStnID>160.68.34.60</wrkStnID>
        <wrkStnType>O</wrkStnType>
    </userInfo>
    <patientAllergyProfile>
        <allergySeqNo>0000090020</allergySeqNo>
        <allergenCode></allergenCode>
        <displayname>METHYLPREDNISOLONE</displayname>
        <ehrLocalDesc></ehrLocalDesc>
        <aliasname></aliasname>
        <salt>ACEPONATE</salt>
        <nameType>D</nameType>
        <allergen>METHYLPREDNISOLONE ACEPONATE</allergen>
        <allergenType>D</allergenType>
        <certainty>Certain</certainty>
        <remark>Asthma</remark>
        <sourceSystem>CMS</sourceSystem>
        <createBy></createBy>
        <createUserName></createUserName>
        <createHosp></createHosp>
        <createRank></createRank>
        <createRankDesc></createRankDesc>
        <createDtm>2019-09-24 09:47:59.0</createDtm>
        <updateBy>Y2KMED</updateBy>
        <updateUserName>AA, FORMAT in IP</updateUserName>
        <updateHosp>VH</updateHosp>
        <updateRank>Department Manager (Pharmacy)</updateRank>
        <updateRankDesc>Department Manager (Pharmacy)</updateRankDesc>
        <updateDtm>2019-08-16 17:27:01.0</updateDtm>
        <manifestations>
            <seqNo>0</seqNo>
            <mDesc>Allergic rhinitis</mDesc>
        </manifestations>
        <manifestations>
            <seqNo>0</seqNo>
            <mDesc>Asthma</mDesc>
        </manifestations>
        <manifestations>
            <seqNo>0</seqNo>
            <mDesc>Rash</mDesc>
        </manifestations>
        <hiclSeqNo>12057</hiclSeqNo>
        <hicSeqNos/>
    </patientAllergyProfile>
    <patientAllergyProfile>
        <allergySeqNo>0000087781</allergySeqNo>
        <allergenCode></allergenCode>
        <displayname>ASPIRIN</displayname>
        <ehrLocalDesc></ehrLocalDesc>
        <aliasname></aliasname>
        <salt></salt>
        <nameType>D</nameType>
        <allergen>ASPIRIN</allergen>
        <allergenType>D</allergenType>
        <certainty>Certain</certainty>
        <remark>~!@#$%^&amp;*()_+`-=][\}{|;':",./&gt;?&lt; 1234567890</remark>
        <sourceSystem>CMS</sourceSystem>
        <createBy></createBy>
        <createUserName></createUserName>
        <createHosp></createHosp>
        <createRank></createRank>
        <createRankDesc></createRankDesc>
        <createDtm>2019-09-24 09:47:59.0</createDtm>
        <updateBy>Y2KMED</updateBy>
        <updateUserName>AA, FORMAT in IP</updateUserName>
        <updateHosp>VH</updateHosp>
        <updateRank>Analyst Programmer I</updateRank>
        <updateRankDesc>Analyst Programmer I</updateRankDesc>
        <updateDtm>2019-02-27 14:30:47.0</updateDtm>
        <manifestations>
            <seqNo>0</seqNo>
            <mDesc>Others</mDesc>
        </manifestations>
        <hiclSeqNo>1820</hiclSeqNo>
        <hicSeqNos/>
    </patientAllergyProfile>
    <patientAllergyProfile>
        <allergySeqNo>0000089979</allergySeqNo>
        <allergenCode></allergenCode>
        <displayname>ACTIFED COMPOUND</displayname>
        <ehrLocalDesc></ehrLocalDesc>
        <aliasname>FEDAC CPD LINCTUS</aliasname>
        <salt></salt>
        <nameType>T</nameType>
        <allergen>FEDAC CPD LINCTUS [ACTIFED COMPOUND]</allergen>
        <allergenType>D</allergenType>
        <certainty>Suspected</certainty>
        <remark>aa</remark>
        <sourceSystem>CMS</sourceSystem>
        <createBy></createBy>
        <createUserName></createUserName>
        <createHosp></createHosp>
        <createRank></createRank>
        <createRankDesc></createRankDesc>
        <createDtm>2019-09-24 09:47:59.0</createDtm>
        <updateBy>Y2KMED</updateBy>
        <updateUserName>AA, FORMAT in IP</updateUserName>
        <updateHosp>VH</updateHosp>
        <updateRank>Department Manager (Pharmacy)</updateRank>
        <updateRankDesc>Department Manager (Pharmacy)</updateRankDesc>
        <updateDtm>2019-08-15 16:08:18.0</updateDtm>
        <manifestations>
            <seqNo>0</seqNo>
            <mDesc>Angioedema</mDesc>
        </manifestations>
        <hiclSeqNo>5359</hiclSeqNo>
        <hicSeqNos/>
    </patientAllergyProfile>
    <patientAllergyProfile>
        <allergySeqNo>0000082091</allergySeqNo>
        <allergenCode></allergenCode>
        <displayname>BELZER UW-CSS</displayname>
        <ehrLocalDesc></ehrLocalDesc>
        <aliasname></aliasname>
        <salt></salt>
        <nameType>D</nameType>
        <allergen>BELZER UW-CSS</allergen>
        <allergenType>D</allergenType>
        <certainty>Suspected</certainty>
        <remark></remark>
        <sourceSystem>CMS</sourceSystem>
        <createBy></createBy>
        <createUserName></createUserName>
        <createHosp></createHosp>
        <createRank></createRank>
        <createRankDesc></createRankDesc>
        <createDtm>2019-09-24 09:47:59.0</createDtm>
        <updateBy>Y2KMED</updateBy>
        <updateUserName>AA, FORMAT in IP</updateUserName>
        <updateHosp>VH</updateHosp>
        <updateRank>Medical Officer</updateRank>
        <updateRankDesc>Medical Officer</updateRankDesc>
        <updateDtm>2017-05-12 09:42:48.0</updateDtm>
        <manifestations>
            <seqNo>0</seqNo>
            <mDesc>Stevens-Johnson Syndrome</mDesc>
        </manifestations>
        <hiclSeqNo>25006</hiclSeqNo>
        <hicSeqNos/>
    </patientAllergyProfile>
    <patientAdrProfile>
        <adrSeqNo>0000004366</adrSeqNo>
        <allergenCode></allergenCode>
        <displayname>ASPIRIN</displayname>
        <aliasname></aliasname>
        <salt></salt>
        <nameType>D</nameType>
        <adr>ASPIRIN</adr>
        <adrType>D</adrType>
        <severity>S</severity>
        <remark>~!@#$%^&amp;*()_+`-=][\}{|;':",./&gt;?&lt; 1234567890
 &lt;RRR
 &lt;?
 &lt; ?
 &lt;
 &lt;RRR&gt;
 &lt;&gt;
 qwertyuiopasdfghjklzxcvbnm
 QWERTYUIOPASDFGHJKLZXCVBNM</remark>
        <sourceSystem>CMS</sourceSystem>
        <createBy></createBy>
        <createUserName></createUserName>
        <createHosp></createHosp>
        <createRank></createRank>
        <createRankDesc></createRankDesc>
        <createDtm>2019-09-24 09:47:59.0</createDtm>
        <updateBy>Y2KMED</updateBy>
        <updateUserName>AA, FORMAT in IP</updateUserName>
        <updateHosp>VH</updateHosp>
        <updateRank>Analyst Programmer I</updateRank>
        <updateRankDesc>Analyst Programmer I</updateRankDesc>
        <updateDtm>2019-02-27 14:30:28.0</updateDtm>
        <reactions>
            <seqNo></seqNo>
            <rDesc>Abdominal Pain with Cramps</rDesc>
            <severCode>0</severCode>
            <freqCode>0</freqCode>
        </reactions>
        <reactions>
            <seqNo></seqNo>
            <rDesc>Others</rDesc>
            <severCode>0</severCode>
            <freqCode>0</freqCode>
        </reactions>
        <hiclSeqNo>1820</hiclSeqNo>
        <hicSeqNos/>
    </patientAdrProfile>
    <currentRxDrugProfile>
        <isCapdItem>false</isCapdItem>
        <type>S</type>
        <rGenId>5254937</rGenId>
        <rDfGenId>19506</rDfGenId>
        <gcnSeqNo>28829</gcnSeqNo>
        <trueDisplayName>METHYLPREDNISOLONE</trueDisplayName>
        <drugDisplayName>Methylprednisolone Aceponate</drugDisplayName>
        <drugErrorDisplayName>Methylprednisolone Aceponate ointment 0.1% 10g</drugErrorDisplayName>
        <arrayPos>0</arrayPos>
        <indRow>1</indRow>
        <ordNo>0</ordNo>
        <hospCode>VH</hospCode>
        <delete>false</delete>
        <salt>ACEPONATE</salt>
        <strength>0.1%</strength>
        <drugDdimDisplayName>Methylprednisolone Aceponate ointment</drugDdimDisplayName>
        <formCode>OIN</formCode>
        <itemCode>METH66</itemCode>
        <specRestrict></specRestrict>
        <specInstruct></specInstruct>
        <pharSpec></pharSpec>
        <dataUpdate>N</dataUpdate>
        <ddimDosRelatedCheck>N</ddimDosRelatedCheck>
    </currentRxDrugProfile>
    <hasG6pdDeficiency>true</hasG6pdDeficiency>
    <hasPregnancy>false</hasPregnancy>
    <checkDdim>false</checkDdim>
    <checkDdcm>true</checkDdcm>
    <checkDam>true</checkDam>
    <checkAdr>true</checkAdr>
    <checkDscm>false</checkDscm>
    <checkDrcm>false</checkDrcm>
    <checkDlcm>false</checkDlcm>
    <checkSteroid>false</checkSteroid>
    <callerSourceSystem>PMS</callerSourceSystem>
    <checkDiscon>false</checkDiscon>
</inputParm>
*/
