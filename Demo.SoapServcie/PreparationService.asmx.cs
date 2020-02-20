using Demo.HL7MessageParser.Models;
using Microsoft.Web.Services3.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Demo.SoapServcie
{
    /// <summary>
    /// Summary description for PreparationService
    /// </summary>
    [WebService(Namespace = "http://biz.dms.pms.model.ha.org.hk")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PreparationService : System.Web.Services.WebService
    {
        public WorkContextSoapHeader WorkContext { get; set; }

        [WebMethod]
        [SoapHeader("WorkContext", Direction = SoapHeaderDirection.InOut)]
        [SoapDocumentMethod(ParameterStyle = SoapParameterStyle.Bare)]
        public GetPreparationResponse getPreparation(GetPreparationRequest request)
        {
            WorkContext = new WorkContextSoapHeader();

            /*
            HttpContext.Current.Request.InputStream.Position = 0;

            var jsonString = new StreamReader(HttpContext.Current.Request.InputStream, Encoding.UTF8).ReadToEnd();
            */


            return new GetPreparationResponse { };
        }


        [WebMethod]
        [SoapHeader("WorkContext", Direction = SoapHeaderDirection.InOut)]
        [SoapDocumentMethod(ParameterStyle = SoapParameterStyle.Bare)]
        public GetDrugMdsPropertyHqResponse getDrugMdsPropertyHq(GetDrugMdsPropertyHqRequest request)
        {
            WorkContext = new WorkContextSoapHeader();

            /*
            HttpContext.Current.Request.InputStream.Position = 0;

            var jsonString = new StreamReader(HttpContext.Current.Request.InputStream, Encoding.UTF8).ReadToEnd();
            */

            return new GetDrugMdsPropertyHqResponse { };
        }

    }
}
