using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.DTOs;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Demo.HL7MessageParser.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                var str = @"<biz:getDrugMdsPropertyHq xmlns:biz=""http://biz.dms.pms.model.ha.org.hk/"">
 <arg0>
    <itemCode> AMET02 </itemCode>
    <itemCode> LEVE01 </itemCode>
</arg0>
</biz:getDrugMdsPropertyHq> ";

                
                str = @"<?xml version='1.0' encoding='UTF-8'?>" + str;

                var res = XmlHelper.XmlDeserialize<GetDrugMdsPropertyHqRequest>(str);

                var restr = XmlHelper.XmlSerializeToString(new GetDrugMdsPropertyHqRequest
                {
                    Arg0 = new Arg
                    {
                        ItemCode = new List<string> { "a", "B" }
                    }
                });
            }
            catch (Exception ex)
            {
                ex = ex;
            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //// Application.Run(new HL7MessageParserFormTest());

            //var result = new List<string>().CheckIfSelectedItemExists();
        }

        private static int FindIDX(int index)
        {
            if (index == 1)
            {
                return 0;
            }

            return -1;
        }

        static int Max_Retry_Count = 5;
        private static string GetPatientEnquiry(string caseno)
        {
            int retryCount = 0;

            while (true)
            {
                try
                {
                    if (retryCount == 4)
                    {
                        return "sss";
                    }
                }
                catch
                {
                    retryCount++;

                    if (retryCount == Max_Retry_Count)
                    {
                        throw;
                    }
                }
            }
        }



    }



    public static class EX
    {
        public static bool CheckIfSelectedItemExists(this List<string> list)
        {
            return true;
            //return list.SelectedItems != null 
            //    && lvItemList.SelectedItems.Count > 0 
            //    && !String.IsNullOrEmpty(lvItemList.SelectedItems[0].Text);
        }
    }
}
