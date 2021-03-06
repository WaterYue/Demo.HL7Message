﻿using System.Xml.Serialization;

namespace Demo.HL7MessageParser.Models
{
    [XmlRoot(ElementName = "getPreparation",Namespace = "http://biz.dms.pms.model.ha.org.hk/")]
    public class GetPreparationRequest
    {
        [XmlElement(ElementName = "arg0", Namespace = "")]
        public Arg0 Arg0 { get; set; }
    }

    [XmlRoot(ElementName = "arg0")]
    public class Arg0
    {
        [XmlElement(ElementName = "dispHospCode")]
        public string DispHospCode { get; set; }

        [XmlElement(ElementName = "dispWorkstore")]
        public string DispWorkstore { get; set; }

        [XmlElement(ElementName = "itemCode")]
        public string ItemCode { get; set; }

        [XmlElement(ElementName = "trueDisplayname")]
        public string TrueDisplayname { get; set; }

        [XmlElement(ElementName = "formCode")]
        public string FormCode { get; set; }

        [XmlElement(ElementName = "saltProperty")]
        public string SaltProperty { get; set; }

        [XmlElement(ElementName = "drugScope")]
        public string DrugScope { get; set; }

        [XmlElement(ElementName = "specialtyType")]
        public string SpecialtyType { get; set; }

        [XmlElement(ElementName = "pasSpecialty")]
        public string PasSpecialty { get; set; }

        [XmlElement(ElementName = "pasSubSpecialty")]
        public string PasSubSpecialty { get; set; }

        [XmlElement(ElementName = "costIncluded")]
        public string CostIncluded { get; set; }

        [XmlElement(ElementName = "hqFlag")]
        public string HqFlag { get; set; }
    }

    /*
   <soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:biz="http://biz.dms.pms.model.ha.org.hk/">
   <soapenv:Header/>
   <soapenv:Body>
      <biz:getPreparation>
         <arg0>
            <dispHospCode></dispHospCode>
            <dispWorkstore></dispWorkstore>
            <itemCode>METH66</itemCode>
            <trueDisplayname>METHYLPREDNISOLONE</trueDisplayname>
            <formCode>OIN</formCode>
            <saltProperty>ACEPONATE</saltProperty>
            <drugScope>I</drugScope>
            <specialtyType>I</specialtyType>
            <pasSpecialty></pasSpecialty>
            <pasSubSpecialty></pasSubSpecialty>
            <costIncluded>true</costIncluded>>
            <hqFlag>true</hqFlag>
         </arg0>
      </biz:getPreparation>
   </soapenv:Body>
</soapenv:Envelope>
*/
}
