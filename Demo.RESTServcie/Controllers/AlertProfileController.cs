using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
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
            ValidateHeaders();

            return new AlertProfileResult
            {
                AdrProfile = new List<AdrProfile> { },
                AlertProfile = new List<AlertProfile> { },
                AllergyProfile = new List<AllergyProfile> { },
                SimpleDisplayFormat = new List<SimpleDisplayFormat> { },
                ErrorMessage = new List<object> { }
            };
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
