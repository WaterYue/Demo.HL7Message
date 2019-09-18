using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public interface IMedicationProfileParser  
    {
        void InitializeParam(string restUri, string client_secret, string pathospcode);

        MedicationProfileResult GetMedicationProfile(string caseNumber);
    }
}
