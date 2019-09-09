using Demo.HL7MessageParser.Models;
using Demo.RESTServcie.Controllers;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Xml.Serialization;

namespace Demo.RESTServcie
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.XmlFormatter.UseXmlSerializer = true;

            var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            // Use XmlSerializer for instances of type "Product":
            xml.SetSerializer<AlertInputParm>(new XmlSerializer(typeof(AlertInputParm)));
            xml.SetSerializer<Abc>(new XmlSerializer(typeof(Abc)));


            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }

    [XmlRoot(ElementName = "abc")]
    public class Abc
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "age")]
        public int Age { get; set; }
    }

}
