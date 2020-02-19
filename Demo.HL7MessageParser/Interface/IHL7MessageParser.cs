using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public interface IHL7MessageParser
    {
        string  SaveRemoteHL7PatientToLocal(string caseNumber,out string errorMessage);

        PatientDemoEnquiry GetPatientEnquiry(string caseno);

        MedicationProfileResult GetMedicationProfiles(string caseno);

        AlertProfileResult GetAlertProfiles(AlertInputParm alertinput);
    }
}
