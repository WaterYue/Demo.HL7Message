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
        [Route("")]
        public IEnumerable<MedicationProfileResult> Get()
        {
            return new List<MedicationProfileResult>
            {
                new MedicationProfileResult
                {
                    CaseNum = "HN17000256S",
                    MedProfileId ="101007132"
                }
            };
        }
        //http://localhost:1770/pms-asa/1/medProfiles/HN170002520
        [Route("{casenumber}")]
        public MedicationProfileResult Get(string casenumber)
        {

            ValidateHeaders();

            try
            {
                var caseNumbers = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
                if (caseNumbers.Contains((casenumber ?? string.Empty).ToUpper()))
                {
                    var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("bin/Data/MP/{0}.json", casenumber));

                    var result = JsonHelper.JsonToObjectFromFile<MedicationProfileResult>(fileName);

                    return result;
                }

                return new MedicationProfileResult { };
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("JsonToObjectFromFile - {0}.json failed!:{1}", casenumber, ex.Message));
            }

        }

        private void ValidateHeaders()
        {
            ValidateHeader_Value(HEADER_CLIENT_SECRET, "CLIENT_SECRET");

            ValidateHeader_Value(HEADER_PATHOSPCODE_VALUE, "PATHOSPCODE");
        }
    }
}
