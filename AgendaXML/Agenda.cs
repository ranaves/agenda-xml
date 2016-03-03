using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgendaXML
{
    [XmlRoot("Agenda")]
    public class Agenda
    {
        [XmlElement("Contato")]
        public List<Contato> contato;
    }
}
