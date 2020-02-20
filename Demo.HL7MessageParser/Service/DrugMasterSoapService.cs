using AutoMapper;
using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using Demo.HL7MessageParser.WebProxy;
using Microsoft.Web.Services3.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser
{
    public class DrugMasterSoapService : IDrugMasterSoapService
    {
        private DrugMasterServiceProxy soapservice = new DrugMasterServiceProxy("http://localhost:44368/DrugMasterService.asmx");

        public GetDrugMdsPropertyHqResponse getDrugMdsPropertyHq(Models.GetDrugMdsPropertyHqRequest request)
        {
           // var req = request.ToProxyEntity();

            var returnResponse = soapservice.getDrugMdsPropertyHq(request);


            return new GetDrugMdsPropertyHqResponse { Return = returnResponse.ToList() };
        }

        public Models.GetPreparationResponse getPreparation(Models.GetPreparationRequest request)
        {
          //  var req = request.ToProxyEntity();

            var returnResponse = soapservice.getPreparation(request);

           // var response = returnResponse.ToProxyEntity();

            return returnResponse;
        }
    }

    public static class ObjectMapping
    {
        static ObjectMapping()
        {
            //Mapper.CreateMap<WebProxy.ReturnObj, GetDrugMdsPropertyHqResponse.ReturnObj>()
            //                .ForMember(dest => dest.DrugKey, opt => opt.MapFrom(o => o.drugKey))
            //                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(o => o.itemCode))
            //                .ForMember(dest => dest.DrugMds, opt => opt.MapFrom(o => o.drugMds))
            //                .ForMember(dest => dest.DrugProperty, opt => opt.MapFrom(o => o.drugProperty));

            //Mapper.CreateMap<WebProxy.DrugMDSObj, Models.DrugMDSObj>()
            //                           .ForMember(dest => dest.DuplicateFlag, opt => opt.MapFrom(o => o.duplicateFlag))
            //                           .ForMember(dest => dest.GcnSeqno, opt => opt.MapFrom(o => o.gcnSeqno))
            //                           .ForMember(dest => dest.GroupGcnSeqno, opt => opt.MapFrom(o => o.groupGcnSeqno))
            //                           .ForMember(dest => dest.GroupMoeCheckFlag, opt => opt.MapFrom(o => o.groupMoeCheckFlag))
            //                           .ForMember(dest => dest.GroupRoutedGeneric, opt => opt.MapFrom(o => o.groupRoutedGeneric))
            //                           .ForMember(dest => dest.GroupRouteformGeneric, opt => opt.MapFrom(o => o.groupRouteformGeneric))
            //                           .ForMember(dest => dest.GroupSingleIngred, opt => opt.MapFrom(o => o.groupSingleIngred))
            //                           .ForMember(dest => dest.HiclSeqno, opt => opt.MapFrom(o => o.hiclSeqno))
            //                           .ForMember(dest => dest.MoeCheckFlag, opt => opt.MapFrom(o => o.moeCheckFlag))
            //                           .ForMember(dest => dest.RoutedGeneric, opt => opt.MapFrom(o => o.routedGeneric))
            //                           .ForMember(dest => dest.RouteformGeneric, opt => opt.MapFrom(o => o.routeformGeneric));

            //Mapper.CreateMap<WebProxy.DrugProperty, Models.DrugProperty>()
            //                          .ForMember(dest => dest.Displayname, opt => opt.MapFrom(o => o.displayname))
            //                          .ForMember(dest => dest.DosageCompul, opt => opt.MapFrom(o => o.dosageCompul))
            //                          .ForMember(dest => dest.DrugKey, opt => opt.MapFrom(o => o.drugKey))
            //                          .ForMember(dest => dest.FixedPeriod, opt => opt.MapFrom(o => o.fixedPeriod))
            //                          .ForMember(dest => dest.FormCode, opt => opt.MapFrom(o => o.formCode))
            //                          .ForMember(dest => dest.SaltProperty, opt => opt.MapFrom(o => o.saltProperty))
            //                          .ForMember(dest => dest.ScreenDisplayname, opt => opt.MapFrom(o => o.screenDisplayname))
            //                          .ForMember(dest => dest.ScreenSalt, opt => opt.MapFrom(o => o.screenSalt))
            //                          .ForMember(dest => dest.StrengthCompul, opt => opt.MapFrom(o => o.strengthCompul))
            //                          .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(o => o.updateDate))
            //                          .ForMember(dest => dest.UpdateUser, opt => opt.MapFrom(o => o.updateUser))
            //                          .ForMember(dest => dest.UpdateVersion, opt => opt.MapFrom(o => o.updateVersion));

            //Mapper.CreateMap<Models.GetPreparationRequest, WebProxy.GetPreparationRequest>()
            //                   .ForMember(dest => dest.arg0, opt => opt.MapFrom(o => o.Arg0))
            //                   .ForMember(dest => dest.Xmlns, opt => opt.Ignore());




            //Mapper.CreateMap<Models.Arg0, WebProxy.Arg0>()
            //                          .ForMember(dest => dest.dispHospCode, opt => opt.MapFrom(o => o.DispHospCode))
            //                          .ForMember(dest => dest.dispWorkstore, opt => opt.MapFrom(o => o.DispWorkstore))
            //                          .ForMember(dest => dest.itemCode, opt => opt.MapFrom(o => o.ItemCode))
            //                          .ForMember(dest => dest.trueDisplayname, opt => opt.MapFrom(o => o.TrueDisplayname))
            //                          .ForMember(dest => dest.formCode, opt => opt.MapFrom(o => o.FormCode))
            //                          .ForMember(dest => dest.saltProperty, opt => opt.MapFrom(o => o.SaltProperty))
            //                          .ForMember(dest => dest.drugScope, opt => opt.MapFrom(o => o.DrugScope))
            //                          .ForMember(dest => dest.specialtyType, opt => opt.MapFrom(o => o.SpecialtyType))
            //                          .ForMember(dest => dest.pasSpecialty, opt => opt.MapFrom(o => o.PasSpecialty))
            //                          .ForMember(dest => dest.pasSubSpecialty, opt => opt.MapFrom(o => o.PasSubSpecialty))
            //                          .ForMember(dest => dest.costIncluded, opt => opt.MapFrom(o => o.CostIncluded))
            //                          .ForMember(dest => dest.hqFlag, opt => opt.MapFrom(o => o.HqFlag));
        }

        //public static WebProxy.GetDrugMdsPropertyHqRequest ToProxyEntity(this Models.GetDrugMdsPropertyHqRequest entity)
        //{
        //    var result = new WebProxy.GetDrugMdsPropertyHqRequest { arg0 = entity.Arg0.ItemCode.ToArray() };

        //    return result;
        //}
        //public static List<GetDrugMdsPropertyHqResponse.ReturnObj> ToProxyEntity(this WebProxy.ReturnObj[] entity)
        //{
        //    try
        //    {
        //        var lmr = Mapper.Map<ReturnObj[], List<GetDrugMdsPropertyHqResponse.ReturnObj>>(entity);

        //        return lmr;
        //    }
        //    catch (Exception ex)
        //    {
        //        ex = ex;
        //    }
        //    return null;
        //}

        //public static WebProxy.GetPreparationRequest ToProxyEntity(this Models.GetPreparationRequest entity)
        //{
        //    try
        //    {
        //        var lmr = Mapper.Map<Models.GetPreparationRequest, WebProxy.GetPreparationRequest>(entity);

        //        return lmr;
        //    }
        //    catch (Exception ex)
        //    {
        //        ex = ex;
        //    }

        //    return null;
        //}
        //public static Models.GetPreparationResponse ToProxyEntity(this WebProxy.GetPreparationResponse entity)
        //{
        //    try
        //    {
        //        var str = XmlHelper.XmlSerializeToString(entity);

        //        var res2 = XmlHelper.XmlDeserialize<Models.GetPreparationResponse>(str);

        //        return res2;
        //    }
        //    catch (Exception ex)
        //    {
        //        ex = ex;
        //    }

        //    return null; ;
        //}

    }

}
