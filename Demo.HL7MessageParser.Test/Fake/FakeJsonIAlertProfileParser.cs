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
        public AlertProfileResult GetAlertProfile(AlertInputParm alertInputParm)
        {
            if (alertInputParm == null)
            {
                //BAD REQUEST
                throw new Exception("invalid request body!");
            }

            if (alertInputParm.PatientInfo == null
                || string.IsNullOrEmpty(alertInputParm.PatientInfo.Hkid))
            {
                //BAD REQUEST
                throw new Exception("invalid Hkid!");
            }

            try
            {
                var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Data/AP/{0}.json", alertInputParm.PatientInfo.Hkid));

                var result = JsonHelper.JsonToObjectFromFile<AlertProfileResult>(fileName);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("JsonToObjectFromFile - {0}.json failed!:{1}", alertInputParm.PatientInfo.Hkid, ex.Message));

            }
        }
    }
}
