using System.Collections.Generic;
using System.Xml.Serialization;

namespace BingDictYoudaoConverter.Models
{
    [XmlRoot("Phrase")]
    public class Phrase
    {
        [XmlElement("Eng")]
        public string Eng { get; set; }

        [XmlElement("Phonetic")]
        public string Phonetic { get; set; }

        [XmlElement("Defi")]
        public string Defi { get; set; }

        [XmlElement("Date")]
        public string Date { get; set; }

        [XmlElement("Note")]
        public string Note { get; set; }
    }

    [XmlRoot("FCVocaPhraseList")]
    public class PhraseList
    {
        [XmlArray("Phrases")]
        [XmlArrayItem("Phrase")]
        public List<Phrase> Phrases { get; set; }
    }
}
