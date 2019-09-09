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
    public class AlertProfileController : ApiController
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
            return new AlertProfileResult
            {
                AdrProfile = new List<AdrProfile> { },
                AlertProfile = new List<AlertProfile> { },
                AllergyProfile = new List<AllergyProfile> { },
                SimpleDisplayFormat = new List<SimpleDisplayFormat> { },
                ErrorMessage = new List<object> { }
            };
        }

        [Route("{hkid}")]
        public void Put(string hkid, [FromBody] Abc value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
 