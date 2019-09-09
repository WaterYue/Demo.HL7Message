using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.RESTServcie.Controllers
{
    [RoutePrefix(Const.ROUNT_PREFIX + "medProfiles")]
    public class MedProfileController : ApiController
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
            return new MedicationProfileResult
            {
                CaseNum = casenumber,
                MedProfileId = "101007132"
            };
        }
    }
}
