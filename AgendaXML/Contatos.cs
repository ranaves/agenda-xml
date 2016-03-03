using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgendaXML
{
    [Serializable()]
    [XmlRoot("Contatos")]
    public class Contatos
    {
        [XmlElement("Contato")]
        public List<Contato> Contato;
    }
}
