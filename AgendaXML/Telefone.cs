using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgendaXML
{
    [Serializable()]
    public class Telefone
    {
        public Telefone() { }

        public Telefone(string tipo, string numero)
        {
            this.Tipo = tipo;
            this.Numero = numero;
        }

        [XmlElement("Tipo")]
        public string Tipo { get; set; }
        [XmlElement("Numero")]
        public string Numero { get; set; }
    }
}
