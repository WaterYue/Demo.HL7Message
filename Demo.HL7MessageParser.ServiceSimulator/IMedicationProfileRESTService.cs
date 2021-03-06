﻿using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Demo.HL7MessageParser.ServiceSimulator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMedicationProfileRESTService
    {

        [OperationContract]
        [WebGet(UriTemplate = "/MedicationProfile", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        MedicationProfileResult GetMedicationProfile();

        // TODO: Add your service operations here
    }
}
