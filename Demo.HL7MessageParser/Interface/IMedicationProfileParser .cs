using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public interface IMedicationProfileParser  
    {
        void InitializeParam();

        MedicationProfileResult GetMedicationProfile(string caseNumber);
    }
}
