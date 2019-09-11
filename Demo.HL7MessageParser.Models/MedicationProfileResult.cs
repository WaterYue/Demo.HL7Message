using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.Models
{

    public class MedicationProfileResult
    {
        public MedicationProfileResult()
        {

        }
        public string MedProfileId { get; set; }

        public string CaseNum { get; set; }

        public List<MedProfileMoItem> MedProfileMoItems { get; set; }
    }

    public class MedProfileMoItem
    {
        public MedProfileMoItem()
        {

        }
        public long MedProfileMoItemId { get; set; }

        public List<MedProfilePoItem> MedProfilePoItems { get; set; }
    }

    public class MedProfilePoItem
    {
        public MedProfilePoItem()
        {

        }
        public long MedProfilePoItemId { get; set; }

        public string ItemCode { get; set; }
    }
}
