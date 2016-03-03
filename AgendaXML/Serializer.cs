using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AgendaXML
{
    public static class Serializer
    {
        // xml para um tipo específico (objeto)
        public static T Deserialize<T>(this XElement XElement)
        {
            using (var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(XElement.ToString())))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(memoryStream);
            }
        }

        // objeto (tipo específico) para um xml
        public static XElement Serialize<T>(this object o)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, o);
                    return XElement.Parse(Encoding.ASCII.GetString(memoryStream.ToArray()));
                }
            }
        }
    }
}
