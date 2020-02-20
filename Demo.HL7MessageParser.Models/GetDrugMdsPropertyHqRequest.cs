using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Demo.HL7MessageParser.Models
{


    [XmlRoot(ElementName = "getDrugMdsPropertyHq", Namespace = "http://biz.dms.pms.model.ha.org.hk/")]
    public class GetDrugMdsPropertyHqRequest
    {
        [XmlElement(ElementName = "arg0")]
        public Arg Arg0 { get; set; }


    }

    [XmlRoot(ElementName = "arg0")]
    public class Arg
    {
        [XmlElement(ElementName = "itemCode")]
        public List<string> ItemCode { get; set; }
    }

}
/*
 <soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:biz="http://biz.dms.pms.model.ha.org.hk/">
   <soapenv:Header/>
   <soapenv:Body>
      <biz:getDrugMdsPropertyHq>
         <arg0>
            <itemCode>AMET02</itemCode>
            <itemCode>METH66</itemCode>
            <itemCode>DEXT1Q</itemCode>
            <itemCode>LEVE01</itemCode>
         </arg0>
      </biz:getDrugMdsPropertyHq>
   </soapenv:Body>
</soapenv:Envelope>
*/

