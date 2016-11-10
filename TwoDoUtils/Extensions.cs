using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TwoDoUtils
{
    public static class Extensions
    {
        public static string ImageToString(this Image value)
        {
            if ( value == null)
            {
                return string.Empty;
            }
            using (Image image = value)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        public static Image LoadFromString(this Image value, string base64String)
        {
            if (!string.IsNullOrEmpty(base64String))
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    value = Image.FromStream(ms, true);
                    return value;
                }
            }
            else
                return value;
        }

        public static T GetAttributeOfType<T>(this Enum enumVal) where T : System.Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
        
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        public static string GetNodeStringOrEmpty(this XmlNode node, string nodeName)
        {
            var _node = node.SelectSingleNode(nodeName);
            if (_node == null) return string.Empty;
            else return _node.InnerText;
        }

        public static string GetNodeXmlOrEmpty(this XmlNode node, string nodeName)
        {
            var _node = node.SelectSingleNode(nodeName);
            if (_node == null) return string.Empty;
            else return _node.OuterXml;
        }
    }
}
