using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;

namespace Demo.HL7MessageParser.Test.Fake
{
    public class FakeJSONMedicationProfileParser : IMedicationProfileParser
    {
        public MedicationProfileResult GetMedicationProfile(string casenumber)
        {
            try
            {
                var caseNumbers = new string[] { "HN03191100Y", "HN17000256S", "HN18001140Y", "HN170002512", "HN170002520", };
                if (caseNumbers.Contains((casenumber ?? string.Empty).ToUpper()))
                {
                    var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Data/MP/{0}.json", casenumber));

                    var result = JsonHelper.JsonToObjectFromFile<MedicationProfileResult>(fileName);

                    return result;
                }

                return new MedicationProfileResult { };
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("JsonToObjectFromFile - {0}.json failed!:{1}", casenumber, ex.Message));
            }
        }

        public void InitializeParam()
        {
            throw new NotImplementedException();
        }
    }
}
