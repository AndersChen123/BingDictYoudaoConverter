using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BingDictYoudaoConverter
{
    public static class SerializeHelper
    {
        public static T FromXML<T>(string xml)
        {
            using (var stringReader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
        }

        public static string ToXml<T>(T obj)
        {
            using (var ms = new MemoryStream())
            using (var stringWriter = new XmlTextWriter(ms, null)) // Omit encoding
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stringWriter, obj);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}
