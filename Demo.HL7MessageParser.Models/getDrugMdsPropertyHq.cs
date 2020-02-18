using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Demo.HL7MessageParser.Models
{


    [XmlRoot(ElementName = "getDrugMdsPropertyHq")]
    public class getDrugMdsPropertyHq
    {
        private XmlSerializerNamespaces xmlns;

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns
        {
            get
            {
                if (xmlns == null)
                {

                    xmlns = new XmlSerializerNamespaces();
                    xmlns.Add("biz", "http://biz.dms.pms.model.ha.org.hk/");
                }
                return xmlns;
            }
            set { xmlns = value; }
        }

        [XmlElement(ElementName = "arg0")]
        public GetDrugMdsPropertyHq_Arg0 Arg0 { get; set; }
    }

    [XmlRoot(ElementName = "arg0")]
    public class GetDrugMdsPropertyHq_Arg0
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

