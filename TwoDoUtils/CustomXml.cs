using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TwoDoUtils
{
    public class CustomXml : XmlDocument
    {
        private string RootNode { get; set; }

        public CustomXml(string rootnode)
        {
            XmlNode rootNode = this.CreateElement(rootnode);
            this.AppendChild(rootNode);
            RootNode = rootnode;
        }

        private void AddNode(string node, string textValue)
        {
            XmlNode Node = this.SelectSingleNode(node);
            if (Node == null)
            {
                Node = this.CreateElement(node);
                Node.InnerText = textValue;
            }
            else { Node.InnerText = textValue; }
            this.FirstChild.AppendChild(Node);            
        }
        
        private void AddNode(CustomXml node)
        {
            XmlNode Node = ImportNode(node.SelectSingleNode(node.RootNode),true);                   
            this.FirstChild.AppendChild(Node);            
        }

        public void Node(string nodeName, string value)
        {
            XmlNode Node = this.SelectSingleNode("/"+ RootNode+"/"+nodeName);
            if (Node == null)
            {
                AddNode(nodeName, value);
            }
            else
            {
                Node.InnerText = value;
            }
        }

        public void Node(CustomXml node, string innerNode = "")
        {
            XmlNode Node = this.SelectSingleNode("/" + (string.IsNullOrEmpty(innerNode) ? "" : innerNode + "/") + node.RootNode);
            if (Node == null)
            {
                AddNode(node);
            }
            else
            {
                Node.InnerXml = node.SelectSingleNode(node.RootNode).InnerXml;
            }
        }        
    }

    public class XmlException : Exception
    {
        public XmlException(string message) : base(message)
        {  }
    }

}
