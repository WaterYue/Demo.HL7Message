using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;

namespace Demo.HL7MessageParser.Test.Fake
{
    public class FakeJsonIAlertProfileParser : IAlertProfileParser
    {
        static List<string> HKIDs = new List<string> { "HN03191100Y", "HN170002520" };

        public AlertProfileResult GetAlertProfile(AlertInputParm alertInputParm)
        {
            //invalid HKID
            if (alertInputParm.PatientInfo == null
                || string.IsNullOrEmpty(alertInputParm.PatientInfo.Hkid)
                || alertInputParm.PatientInfo.Hkid.ToUpper().StartsWith("INVALID_HKID"))
            {
                return JsonFromFile("INVALID_HKID");
            }
            var tempHKID = alertInputParm.PatientInfo.Hkid.ToUpper();

           // ValidateRequestHeaders();

            if (HKIDs.Contains(tempHKID))
            {
                return JsonFromFile(tempHKID);
            }
            //invalid Patient info
            else
            {
                return JsonFromFile("INVALID_PATIENT");
            }
        }

        private static AlertProfileResult JsonFromFile(string hkId)
        {
            try
            {
                var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("bin/Data/AP/{0}.json", hkId));

                var result = JsonHelper.JsonToObjectFromFile<AlertProfileResult>(fileName);
                return result;
            }
            catch (Exception)
            {
                var errorStr = string.Format("JsonToObjectFromFile - {0}.json failed!", hkId);
                throw new Exception(errorStr);

                //throw new HttpResponseException(new HttpResponseMessage
                //{
                //    StatusCode = HttpStatusCode.InternalServerError,
                //    Content = new StringContent(errorStr),
                //    ReasonPhrase = errorStr,
                //});
            }
        }

        public void InitializeParam()
        {
            throw new NotImplementedException();
        }
    }
}
