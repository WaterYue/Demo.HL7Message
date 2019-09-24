using AutoMapper;
using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Model;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public static class ObjectAutoMapping
    {
        static ObjectAutoMapping()
        {
            Mapper.CreateMap<PatientDemoEnquiry, PatientObj>()
                            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(o => o.Patient.Name))
                            .ForMember(dest => dest.LastName, opt => opt.MapFrom(o => o.Patient.Name))
                            .ForMember(dest => dest.MiddleInitial, opt => opt.Ignore())
                            .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(o => DateTime.ParseExact(o.Patient.DOB, "yyyyMMdd", CultureInfo.InvariantCulture)))
                            .ForMember(dest => dest.Gender, opt => opt.MapFrom(o => o.Patient.Sex))
                            .ForMember(dest => dest.Height, opt => opt.Ignore())
                            .ForMember(dest => dest.Weight, opt => opt.Ignore())
                            .ForMember(dest => dest.Alias, opt => opt.Ignore())
                            .ForMember(dest => dest.MedicalRecordNumber, opt => opt.MapFrom(o => o.Patient.HKID))
                            .ForMember(dest => dest.Physician, opt => opt.Ignore())
                            .ForMember(dest => dest.PatientType, opt => opt.Ignore())  // need to be ignore, data type cause failure with AutoMapper.
                            .ForMember(dest => dest.PatientFacilityID, opt => opt.Ignore())
                            .ForMember(dest => dest.MDSiteName, opt => opt.Ignore());

            Mapper.CreateMap<Case, VisitObj>()
                  .ForMember(dest => dest.PatientVisitId, opt => opt.Ignore())
                  .ForMember(dest => dest.PatientID, opt => opt.Ignore())
                  // wardCode -- wardID need to get from DB by searching.
                  // .ForMember(dest => dest.CareUnitId, opt => opt.MapFrom(o => int.Parse(o.WardCode)))
                  .ForMember(dest => dest.AdmitDate, opt => opt.MapFrom(o => DateTime.ParseExact(o.AdmissionDatetime, "yyyyMMdd HH:mm", CultureInfo.InvariantCulture)))
                  .ForMember(dest => dest.DischargeDate, opt => opt.Ignore())
                  .ForMember(dest => dest.Room, opt => opt.Ignore())
                  .ForMember(dest => dest.Bed, opt => opt.MapFrom(o => o.BedNo))
                  .ForMember(dest => dest.AccountNumber, opt => opt.Ignore())
                  .ForMember(dest => dest.Barcode, opt => opt.Ignore())
                 // .ForMember(dest => dest.HospitalService, opt => opt.MapFrom(o => o.Number));
                 ;
        }
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
            PatientVisit pv = new PatientVisit();
            PatientObj p = Mapper.Map<PatientDemoEnquiry, PatientObj>(pr);

            pv.Pateint = p;
          
            foreach (var item in pr.CaseList)
            {
                VisitObj v = Mapper.Map<Case, VisitObj>(item);
                v.PatientID = p.PatientId;

                pv.Vists.Add(v);
            }

            return pv;
        }
        public static IEnumerable<PatientAllergyObj> ToConvert(this AlertProfileResult apr)
        {
            return new List<PatientAllergyObj>();
        }
    }
}
