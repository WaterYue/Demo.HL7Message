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

            return new MedicationProfileResult
            {
                CaseNum = casenumber,
                MedProfileId = "101007132"
            };
        }

        private void ValidateHeaders()
        {
            ValidateHeader_Value(HEADER_CLIENT_SECRET, "CLIENT_SECRET");

            ValidateHeader_Value(HEADER_PATHOSPCODE_VALUE, "PATHOSPCODE");
        }
    }
}
