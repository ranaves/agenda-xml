using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace AgendaXML
{
    public class SContatos
    {
        static string arquivo = @"C:\Desenvolvimento\Agenda.xml";
        static XmlDocument xmlDoc = new XmlDocument();
        static XElement xDoc;
        static Contatos contatos;

        public static void CheckFile()
        {
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }
        }

        public static void Write(Contatos contatos)
        {
            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);
            xmlReturn.Save(arquivo);
        }

        public static Contatos Read()
        {
            CheckFile();

            xDoc = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xDoc);

            return contatos;
        }
    }
}
