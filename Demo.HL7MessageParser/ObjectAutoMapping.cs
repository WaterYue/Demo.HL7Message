using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public static class ObjectAutoMapping
    {
        public static Order ToConvert(this MedProfileMoItem mp)
        {
            return new Order();
        }

        public static IEnumerable<Order> ToConvert(this IEnumerable<MedProfileMoItem> mps)
        {
            return new List<Order>();
        }

        public static PatientVisit ToConvert(this PatientDemoEnquiry pr)
        {
            return new PatientVisit();
        }
        public static IEnumerable<Allergy> ToConvert(this AlertProfileResult apr)
        {
            return new List<Allergy>();
        }
    }
}
