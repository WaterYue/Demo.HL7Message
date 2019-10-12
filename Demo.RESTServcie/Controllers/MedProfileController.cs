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
    [RoutePrefix(Const.ROUNT_PREFIX + "medProfiles")]
    public class MedProfileController : BaseController
    {
        static List<string> caseNumbers = new List<string> { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };

        const string LOCAL_PATH_Format = "bin/Data/MP/{0}.json";

        [Route("")]
        public IEnumerable<MedicationProfileResult> Get()
        {
            var result = new List<MedicationProfileResult>();

            caseNumbers.ForEach(casenumber => result.Add(JsonFromFile(casenumber)));

            return result;
        }

        //http://localhost:1770/pms-asa/1/medProfiles/HN170002520
        [Route("{casenumber}")]
        public MedicationProfileResult Get(string casenumber)
        {
            if (!string.IsNullOrWhiteSpace(casenumber))
            {
                ValidateHeader_Value(HEADER_CLIENT_SECRET, PARAM_CLIENT_SECRET);
                
                if (IsValidateHeader_Value(HEADER_PATHOSPCODE, PARAM_PATHOSPCODE))
                {
                    if (caseNumbers.Contains(casenumber.ToUpper()))
                    {
                        return JsonFromFile(casenumber);
                    }
                }
            }
            //invalid pat_hospcode OR casenumber, return empty object
            return new MedicationProfileResult { };
        }

        private MedicationProfileResult JsonFromFile(string casenumber)
        {
            try
            {
                var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(LOCAL_PATH_Format, casenumber));

                var result = JsonHelper.JsonToObjectFromFile<MedicationProfileResult>(fileName);
                return result;
            }
            catch (Exception)
            {
                var errorStr = string.Format("JsonToObjectFromFile - {0}.json failed!", casenumber);

                throw new HttpResponseException(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Content = new StringContent(errorStr),
                    ReasonPhrase = errorStr,
                });
            }
        }
    }
}
