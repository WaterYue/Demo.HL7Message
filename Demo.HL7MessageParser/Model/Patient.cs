using Demo.HL7MessageParser.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.Model
{

    public class Order
    {
    }

    public class PatientVisit
    {
        public PatientVisit()
        {
            Vists = new List<VisitObj>();
        }
        public PatientObj Pateint { get; set; }
        public List<VisitObj> Vists { get; set; }
    }
}
