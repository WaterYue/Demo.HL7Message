using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Demo.HL7MessageParser.Models;

namespace Demo.HL7MessageParser.ServiceSimulator
{
    public class MedicationProfileRESTService : IMedicationProfileRESTService
    {
        public MedicationProfileResult GetMedicationProfile()
        {
            return new MedicationProfileResult { CaseNum="9527" };
        }
    }
}
