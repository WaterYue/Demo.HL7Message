using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HL7MessageParser.WinForms
{
    public static class Global
    {
        public static string RestUri { get; set; }

        public static string SoapUri { get; set; }

        public static string UserName { get; set; }

        public static string Password { get; set; }

        public static string HospitalCode { get; set; }
        public static string ClientSecret { get; set; }

        public static string AccessCode { get; set; }
        public static string ClientId { get; private set; }

        public static void Initialize()
        {
            RestUri = ConfigurationManager.AppSettings["RestUri"].ToString();

            SoapUri = ConfigurationManager.AppSettings["SoapUri"].ToString();

            UserName = ConfigurationManager.AppSettings["Token_Username"].ToString();

            Password = ConfigurationManager.AppSettings["Token_Password"].ToString();

            ClientSecret = ConfigurationManager.AppSettings["client_secret"].ToString();

            HospitalCode = ConfigurationManager.AppSettings["patHospCode"].ToString();

            AccessCode = ConfigurationManager.AppSettings["AccessCode"].ToString();

            ClientId = "AccessCenter";

        }
    }
}
