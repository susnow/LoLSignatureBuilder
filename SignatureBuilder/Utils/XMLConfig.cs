using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;



namespace SignatureBuilder.Utils
{
    public class XMLConfig
    {
        string myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string curVersion = "2.5";

        public string GetXmlNodeValue(string key)
        {
            string nodevalue = "";
            string config = myDocument + "\\LoLSignatureBuilder.xml";
            if (!configExist())
            {
                CreateXmlConfig();
            }
            XmlDocument xml = new XmlDocument();
            xml.Load(config);
            XmlNode nodeConfig = xml.SelectSingleNode("Config");
            XmlNodeList nodes = nodeConfig.ChildNodes;
            if (nodes.Count > 0)
            {
                foreach (XmlElement element in nodes)
                {
                    if (element.Name == key)
                    {
                        nodevalue = element.InnerText;
                    }
                }
            }
            return nodevalue;
        }

        public void CreateXmlConfig()
        {
            string config = myDocument + "\\LoLSignatureBuilder.xml";
            if (!File.Exists(config))
            {
                XmlDocument xml = new XmlDocument();
                xml.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" ?><Config></Config>");
                XmlNode nodeConfig = xml.SelectSingleNode("Config");

                XmlElement nodeVersion = xml.CreateElement("Version");
                nodeVersion.InnerText = curVersion;
                nodeConfig.AppendChild(nodeVersion);

                XmlElement nodeFilePath = xml.CreateElement("LoLFilePath");
                RegKey regkey = new RegKey();
                nodeFilePath.InnerText = regkey.client == "" ? "": regkey.client;
                nodeConfig.AppendChild(nodeFilePath);

                XmlElement nodeSavePath = xml.CreateElement("SavePath");
                nodeSavePath.InnerText = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                nodeConfig.AppendChild(nodeSavePath);

                xml.Save(config);
            }
            else 
            {
                UpdateOldXmlConfig();
            }
        }

        public bool configExist()
        {
            string config = myDocument + "\\LoLSignatureBuilder.xml";
            if (File.Exists(config))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string LoLFilepath
        {
            get
            {
                string lolfilepath = GetXmlNodeValue("LoLFilePath");
                return lolfilepath;
            }
            set
            {
                this.LoLFilepath = value;
            }
        }

        public string ProductVersion
        {
            get
            {
                string version = GetXmlNodeValue("Version");
                return version;
            }
            set
            {
                this.ProductVersion = value;
            }
        }

        public string SavePath 
        {
            get 
            {
                string savepath = GetXmlNodeValue("SavePath");
                return savepath;
            }
            set 
            {
                this.SavePath = value;
            }   
        }

        public bool CheckXmlConfigNodeExist(string nodeName)
        {
            bool _exist = false;
            string config = myDocument + "\\LoLSignatureBuilder.xml";
            if (!configExist())
            {
                CreateXmlConfig();
            }

            XmlDocument xml = new XmlDocument();
            xml.Load(config);
            XmlNode nodeConfig = xml.SelectSingleNode("Config");
            XmlNodeList nodes = nodeConfig.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                if (node.Name != nodeName)
                {
                    _exist = false;
                }
                else
                {
                    _exist = true;
                    return _exist;
                }
            }
            return _exist;
        }

        public void InsertXmlNode(string key, string value)
        {
            string config = myDocument + "\\LoLSignatureBuilder.xml";
            if (!configExist())
            {
                CreateXmlConfig();
            }
            XmlDocument xml = new XmlDocument();
            xml.Load(config);
            XmlNode nodeConfig = xml.SelectSingleNode("Config");
            XmlElement element = xml.CreateElement(key);
            element.InnerText = value;
            nodeConfig.AppendChild(element);

            xml.Save(config);
        }

        public void EditXmlNodeValue(string key, string value)
        {
            string config = myDocument + "\\LoLSignatureBuilder.xml";
            if (!configExist())
            {
                CreateXmlConfig();
            }
            XmlDocument xml = new XmlDocument();
            xml.Load(config);
            XmlNode nodeConfig = xml.SelectSingleNode("Config");
            XmlNodeList nodes = nodeConfig.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                if (node.Name == key)
                {
                    node.InnerText = value;
                }
                else
                {

                }
            }
            xml.Save(config);
        }

        public void UpdateOldXmlConfig()
        {
            XMLConfig cfg = new XMLConfig();
            if (cfg.ProductVersion != null && cfg.ProductVersion == curVersion)
            {
                return;
            }

            if (!CheckXmlConfigNodeExist("Version"))
            {
                InsertXmlNode("Version", curVersion);
            }
            else
            {
                EditXmlNodeValue("Version", curVersion);
            }
        }
    }
}
