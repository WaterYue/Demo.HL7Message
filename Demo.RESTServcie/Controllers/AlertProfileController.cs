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
        static List<string> HKIDs = new List<string>
        {
            "HN03191100Y",
            "HN17000256S",
            "HN18001140Y",
            "HN170002512",
            "HN170002520",
            "INVALID_HKID",
            "INVALID_PATIENT",
            "INVALID_ACCESSCODE"
        };

        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{hkid}")]
        public AlertProfileResult Get(string hkid)
        {
            if (string.IsNullOrEmpty(hkid))
            {
                this.ThrowHttpResponseExceptions(HttpStatusCode.BadRequest, string.Format("Invalid Hkid({0})", hkid));
            }

            ValidateRequestHeaders();

            return JsonFromFile(hkid);
        }

        [Route("")]
        public AlertProfileResult Post([FromBody]AlertInputParm alertInputParm)
        {
            if (alertInputParm == null)
            {
                this.ThrowHttpResponseExceptions(HttpStatusCode.BadRequest, "alertInputParm is null!");
            }

            ValidateRequestHeaders();

            //invalid HKID
            if (alertInputParm.PatientInfo == null
                || string.IsNullOrEmpty(alertInputParm.PatientInfo.Hkid)
                || alertInputParm.PatientInfo.Hkid.ToUpper().StartsWith("INVALID_HKID"))
            {
                return JsonFromFile("INVALID_HKID");
            }
            var tempHKID = alertInputParm.PatientInfo.Hkid.ToUpper();

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

                throw new HttpResponseException(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Content = new StringContent(errorStr),
                    ReasonPhrase = errorStr,
                });
            }
        }

        private void ValidateRequestHeaders()
        {
            /*client_secret: G5nWL4fdPQp3XbWTm9qaQUbedsN4zMzVmn5CfeKxkwjteHGw6SreJJCS8gVD74RN
             * client_id: dispCabinet
             * pathospcode:
             */
            ValidateHeader_Value(HEADER_CLIENT_SECRET, "CLIENT_SECRET");

            //  ValidateHeader_Value(HEAER_CLIENT_ID, "CLIENT_ID");

            ValidateHeader_Value(HEADER_PATHOSPCODE_VALUE, "PATHOSPCODE");
        }
    }
}
