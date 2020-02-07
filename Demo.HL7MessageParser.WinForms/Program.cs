using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //// Application.Run(new HL7MessageParserFormTest());

            //var result = new List<string>().CheckIfSelectedItemExists();
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

                    throw new Exception("TTT");
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
