using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Demo.HL7MessageParser.Models;

namespace Demo.HL7MessageParser.ServiceSimulator
{
    public class PatientSoapService : IPatientSoapService
    {

        public SearchHKPMIPatientByCaseNoResponseContract searchHKPMIPatientByCaseNo(searchHKPMIPatientByCaseNo caseNo)
        {
            return new SearchHKPMIPatientByCaseNoResponseContract
            {
                SearchHKPMIPatientByCaseNoResponse = new SearchHKPMIPatientByCaseNoResponse
                {
                    PatientDemoEnquiryResult = new PatientDemoEnquiryResult
                    {
                        //Patient = new Patient
                        //{
                        //    HomePhone = "HongKong",
                        //    HKID = "9527"
                        //}
                    }
                }
            };
        }
    }
}
