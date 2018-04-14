using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;

namespace BackEnd
{
    public class XmlHandler
    {
        static string downloadURL = "http://noah.es/xml/kyero.php?f=5969ea3c51105";
        int minutesToWait = 15;

        string xmlPath = @"c:/temp/";
        string xmlName = "xmlData.xml";

        bool runAgain = true;

        public void ModifyXMLManager()
        {
            while (true)
            {
                //Do the stuff you want to be done every hour;
                var _xml = DownloadXML(downloadURL);

                var _modifiedXML = ModifyXML(_xml);

                var _xmlDoc = ConvertToXmlDocument(_modifiedXML);

                SaveXML(_xmlDoc);

                Thread.Sleep(1/*60 * minutesToWait * 1000*/);
            }
        }

        XmlDocument ConvertToXmlDocument(string xml)
        {
            var _xmlDoc = new XmlDocument();

            _xmlDoc.LoadXml(xml);

            return _xmlDoc;
        }

        string ModifyXML(string xml)
        {
            var _res = xml.Replace("<ref>N", "<ref>MS");

            return _res;
        }

        string DownloadXML(string address)
        {
            string text;

            using (var client = new WebClient())
            {
                text = client.DownloadString(address);
            }
            return text;
        }

        void SaveXML(XmlDocument xml)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                if (!Directory.Exists(xmlPath))
                {
                    Directory.CreateDirectory(xmlPath);
                }

                using (XmlWriter writer = XmlWriter.Create(xmlPath+ xmlName, settings))
                {
                    xml.Save(writer);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public string GetCurrentXML()
        {
            var _res = new XmlDocument();
            _res.Load(xmlPath + xmlName);

            return _res.InnerXml;
        }
    }
}

