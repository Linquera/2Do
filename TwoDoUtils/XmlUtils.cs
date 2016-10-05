using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TwoDoUtils
{
    public static class XmlUtils
    {
        public static void AddRootElement(this XmlDocument value, string root)
        {
            if (value.ChildNodes.Count == 0)
            {
                XmlNode rootNode = value.CreateElement(root);
                value.AppendChild(rootNode);
            }
            else
            {
                throw new XmlUtilsException("This instance already have a root element");
            }
        }

        public static void AddNode(this XmlDocument value, string node, string textValue)
        {
            if (value.ChildNodes.Count > 0)
            {
                XmlNode Node = value.SelectSingleNode(node);
                if (Node == null) 
                {
                    Node = value.CreateElement(node);
                    Node.InnerText = textValue; 
                }
                else { Node.InnerText = textValue; }
                value.FirstChild.AppendChild(Node);
            }
            else
            {
                throw new XmlUtilsException("This instance does not have a root element");
            }
        }
        
        public static void AddNode(this XmlDocument value, XmlNode node)
        {
            if (value.ChildNodes.Count > 0)
            {
                value.FirstChild.AppendChild(node);
            }
            else
            {
                throw new XmlUtilsException("This instance does not have a root element");
            }
        }

        public static void AddXmlNode(this XmlDocument value, string node, string XmlValue)
        {
            if (value.ChildNodes.Count > 0)
            {
                XmlNode Node = value.SelectSingleNode(node);
                if (Node == null)
                {
                    Node = value.CreateElement(node);
                    Node.InnerXml = XmlValue;
                    value.FirstChild.AppendChild(Node);
                }
                else { Node.InnerXml += XmlValue; }                
            }
            else
            {
                throw new XmlUtilsException("This instance does not have a root element");
            }
        }
        
        public static void AddXmlNode(this XmlNode value, string XmlValue)
        {
            value.InnerXml += XmlValue;            
        }

    }

    public class XmlUtilsException: Exception
    {
        public XmlUtilsException(string message)  : base(message)
        {
        }
    }
}
