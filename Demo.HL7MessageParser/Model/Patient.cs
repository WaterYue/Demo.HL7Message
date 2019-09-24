using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.Model
{
    public class Allergy
    {
    }

    public class Order
    {
    }

    public class PatientVisit
    {
        public Patient Pateint { get; set; }
        public Visit Vist { get; set; }
    }
    public class Visit
    {
    }

    public class Patient
    {
    }
}
