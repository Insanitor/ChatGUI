using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChatGUI.Models
{
    [XmlRoot(ElementName = "RSAKeyValue")]
    public class RSAKeyValue
    {
        [XmlElement(ElementName = "Modulus")]
        public string Modulus { get; set; }
        [XmlElement(ElementName = "Exponent")]
        public string Exponent { get; set; }
    }
}
