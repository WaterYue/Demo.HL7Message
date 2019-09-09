using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Demo.HL7MessageParser.Common
{
    public static class XmlHelper
    {

        public static XElement GetElementByElementName(XElement doc, string name)
        {
            var element = doc.Element(name);

            if (element == null)
            {
                throw new KeyNotFoundException(string.Format("XName:{0} is not fould", name));
            }

            return element;
        }

        public static XElement GetElementByXname(XElement doc, XNamespace ns, string name)
        {
            var xname = ns + name;

            var element = doc.Element(xname);

            if (element == null)
            {
                throw new KeyNotFoundException(string.Format("XName:{0} is not fould", xname));
            }

            return element;
        }
        public static string Serialize<T>(T obj) where T : class
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(stringwriter, obj);

                return stringwriter.ToString();
            }
        }
        public static T DeserializeFromFile<T>(string fileName) where T : class
        {
            try
            {
                var doc = XElement.Load(fileName);

                using (StringReader strReader = new StringReader(doc.ToString()))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    var result = serializer.Deserialize(strReader) as T;

                    return result;
                }
            }
            catch (Exception ex)
            {
                ex = ex;
            }

            return null;
        }


        public static T Deserialize<T>(string xmlStr, string nameSpace = null) where T : class
        {
            using (StringReader strReader = new StringReader(xmlStr))
            {
                using (var xmlReader = new XmlTextReader(strReader))
                {
                    XmlSerializer serializer = CreateXmlXmlSerializer<T>(nameSpace);

                    if (serializer.CanDeserialize(xmlReader))
                    {
                        var obj = serializer.Deserialize(xmlReader);

                        return obj as T;
                    }
                }
            }

            return null;
        }

        private static XmlSerializer CreateXmlXmlSerializer<T>(string nameSpace) where T : class
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                return new XmlSerializer(typeof(T));
            }

            return new XmlSerializer(typeof(T));
        }
    }
}
