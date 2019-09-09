using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.Models
{

    public partial class MedicationProfileResult
    {
        public long MedProfileId { get; set; }

        public string CaseNum { get; set; }

        public MedProfileMoItem[] MedProfileMoItems { get; set; }
    }

    public partial class MedProfileMoItem
    {
        public long MedProfileMoItemId { get; set; }

        public MedProfilePoItem[] MedProfilePoItems { get; set; }
    }

    public partial class MedProfilePoItem
    {
        public long MedProfilePoItemId { get; set; }

        public string ItemCode { get; set; }
    }
}
