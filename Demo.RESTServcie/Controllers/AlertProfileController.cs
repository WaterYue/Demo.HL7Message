using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;

namespace Demo.RESTServcie.Controllers
{
    [RoutePrefix(Const.ROUNT_PREFIX + "alertProfile")]
    public class AlertProfileController : BaseController
    {
        static AlertProfileController()
        {
            var alertsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin/Data/AP");
            var alerts = Directory.GetFiles(alertsDir, "*.json");

            HKIDs = alerts.Select(o => new FileInfo(o).Name)
                                            .Select(o => o.Substring(0, o.Length - ".json".Length))
                                            .ToList();

        }
        static List<string> HKIDs;


        //static List<string> HKIDs = new List<string>
        //{
        //    "HN03191100Y",
        //    "HN17000256S",
        //    "HN18001140Y",
        //    "HN170002512",
        //    "HN170002520",
        //    "INVALID_HKID",
        //    "INVALID_PATIENT",
        //    "INVALID_ACCESSCODE"
        //};

        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "AlertProfile1", "AlertProfile2" };
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


        /*Accepting Raw Request Body Content with ASP.NET Web API
         *https://weblog.west-wind.com/posts/2013/dec/13/accepting-raw-request-body-content-with-aspnet-web-api
         */
        [Route("")]
        public async Task<AlertProfileResult> PostAsync()
        {
            var contenttype = Request.Content.Headers.ContentType;

            System.Diagnostics.Debug.WriteLine(Request.Content.Headers.ToString());

            string result = await Request.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(result))
            {
                this.ThrowHttpResponseExceptions(HttpStatusCode.BadRequest, "alertInputParm is null!");
            }

            AlertInputParm alertInputParm = null;
            try
            {
                alertInputParm = XmlHelper.XmlDeserialize<AlertInputParm>(result);
            }
            catch
            {
                this.ThrowHttpResponseExceptions(HttpStatusCode.BadRequest, "alertInputParm is null!");
            }


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

        [Obsolete]
        [Route("test")]
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
            ValidateHeader_Value(HEADER_CLIENT_SECRET, PARAM_CLIENT_SECRET);

            //  ValidateHeader_Value(HEAER_CLIENT_ID, "CLIENT_ID");

            ValidateHeader_Value(HEADER_PATHOSPCODE, PARAM_PATHOSPCODE);
        }
    }
}
