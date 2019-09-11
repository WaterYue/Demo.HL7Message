using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.RESTServcie.Controllers
{
    [RoutePrefix(Const.ROUNT_PREFIX + "alertProfile")]
    public class AlertProfileController : BaseController
    {
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{hkid}")]
        public AlertProfileResult Get(string hkid)
        {
            return new AlertProfileResult { };
        }

        [Route("")]
        public AlertProfileResult Post([FromBody]AlertInputParm alertInputParm)
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

            ValidateHeaders();

            try
            {
                var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("bin/Data/AP/{0}.json", alertInputParm.PatientInfo.Hkid));

                var result = JsonHelper.JsonToObjectFromFile<AlertProfileResult>(fileName);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("JsonToObjectFromFile - {0}.json failed!:{1}", alertInputParm.PatientInfo.Hkid, ex.Message));

            }
        }

        private void ValidateHeaders()
        {
            /*client_secret: G5nWL4fdPQp3XbWTm9qaQUbedsN4zMzVmn5CfeKxkwjteHGw6SreJJCS8gVD74RN
             * client_id: dispCabinet
             * pathospcode:
             */
            ValidateHeader_Value(HEADER_CLIENT_SECRET, "CLIENT_SECRET");

            ValidateHeader_Value(HEAER_CLIENT_ID, "CLIENT_ID");

            ValidateHeader_Value(HEADER_PATHOSPCODE_VALUE, "PATHOSPCODE");
        }
    }
}
