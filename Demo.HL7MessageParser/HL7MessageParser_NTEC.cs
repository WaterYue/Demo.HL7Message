using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private IMedicationProfileParser medicationProfileParser;
        private IAlertProfileParser allergiesParser;

        public HL7MessageParser_NTEC()
        {
            Initialize();

            this.patientVisitParser = new SoapPatientVisitParser(SoapUrl, UserName, Password, HospitalCode);

            this.medicationProfileParser = new JSONMedicationProfileParser(RestUrl, ClientSecret, HospitalCode);

            this.allergiesParser = new JSONIAlertProfileParser(RestUrl, ClientSecret, ClientId, HospitalCode);
        }

        private void Initialize()
        {
            //TODO Initialize parameters from DB

            SoapUrl = "http://localhost:8096/PatientService.asmx";
            UserName = "pas-appt-ws-user";
            Password = "pas-appt-ws-user-pwd";


            RestUrl = "http://localhost:3181/pms-asa/1/";
            ClientSecret = "CLIENT_SECRET";
            ClientId = "AccessCenter";

            AccessCode = "AccessCode";
            HospitalCode = "PATHOSPCODE";
        }

        public HL7MessageParser_NTEC(
            IPatientVisitParser patientVisitParser,
            IMedicationProfileParser medicationProfileParser,
            IAlertProfileParser allergiesParser)
        {
            this.patientVisitParser = patientVisitParser;
            this.medicationProfileParser = medicationProfileParser;
            this.allergiesParser = allergiesParser;
        }

        public IEnumerable<Order> GetOrders(string caseno)
        {
            var medicationProfile = medicationProfileParser.GetMedicationProfile(caseno);

            //TODO:storage the response

            var orders = medicationProfile.MedProfileMoItems.ToConvert();

            return orders;
        }

        public PatientVisit GetPatient(string caseno)
        {
            try
            {
                var pr = patientVisitParser.GetPatientResult(caseno);

                //TODO: storage the response Postponse

                var patientVisit = pr.ToConvert();

                //TODO: storage accesscenter business object to db            

                return patientVisit;
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

        public IEnumerable<PatientAllergyObj> GetAllergies(AlertInputParm alertinput)
        {
            alertinput.Credentials.AccessCode = AccessCode;

            var apr = allergiesParser.GetAlertProfile(alertinput);

            //TODO:storage the response

            var result = apr.ToConvert();

            return result;
        }
    }
}
