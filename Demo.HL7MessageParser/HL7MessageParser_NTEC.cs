using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private IPatientVisitParser patientVisitParser;
        private IProfileRestService profileService;

        public HL7MessageParser_NTEC()
        {
            Initialize();

            this.patientVisitParser = new SoapPatientVisitParser(SoapUrl, UserName, Password, HospitalCode);

            this.profileService = new ProfileRestService(RestUrl, ClientSecret, ClientId, HospitalCode);
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
        }

        public HL7MessageParser_NTEC(
            IPatientVisitParser patientVisitParser,
           
            IProfileRestService profileService)
        {
            this.patientVisitParser = patientVisitParser;
            this.profileService = profileService;
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
    }
}
