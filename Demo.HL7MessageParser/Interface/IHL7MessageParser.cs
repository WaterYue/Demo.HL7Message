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
         PatientVisit GetPatient(string caseno);

        IEnumerable<Order> GetOrders(string caseno);

        IEnumerable<Allergy> GetAllergies(AlertInputParm alertinput);
    }
}
