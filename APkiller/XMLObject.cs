using APkiller.Controls.UIprocces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace APkiller
{
    class XMLObject
    {
        public string Pith
        {
            get; set;
        } = "data.xml";
        public void SerializeToXml<T>(T anyobject)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(anyobject.GetType());
            using (StreamWriter writer = new StreamWriter(Pith))
            {
                xmlSerializer.Serialize(writer, anyobject);
            }
        }

        public T DeserializeToObject<T>() where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StreamReader sr = new StreamReader(Pith))
            {
                return (T)ser.Deserialize(sr);
            }
        }
        public List_p DeserializeToObject(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List_p));
            List_p result;
            using (StreamReader sr = new StreamReader(path))
            {
                result = (List_p)serializer.Deserialize(sr);
            }
            return result;
        }
    }
}
