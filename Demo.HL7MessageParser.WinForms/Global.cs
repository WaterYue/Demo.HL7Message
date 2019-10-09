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

        public static void Initialize()
        {
            RestUri = ConfigurationManager.AppSettings["RestUri"].ToString();

            SoapUri = ConfigurationManager.AppSettings["SoapUri"].ToString();
        }
    }
}
