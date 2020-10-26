using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static Main.EngineInfo;

namespace Main
{
     public sealed class Config
    {
        private static Config instance = null;
        public bool first_time = true;
        private static readonly object padlock = new object();
        private List<EngineInfo> apis;
        private string country_codes = "country-codes.xml";
        static string engine_file = "engines.xml";
        public static string facebook_api_app_id = "613066106031488";


        Config()
        {
            Apis = new List<EngineInfo>();
            load_engine_xml();
        }
        public List<Country_Codes> load_country_code_xml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/" + country_codes);
            XmlNode root = doc.DocumentElement;
            XmlNodeList gls = root.SelectNodes("gl");
            List<Country_Codes> codes = new List<Country_Codes>();
            foreach (XmlNode gl in gls)
            {
                XmlNodeList tds = gl.SelectNodes("td");
                string name = tds.Item(0).InnerText;
                string code = tds.Item(1).InnerText;
                codes.Add(new Country_Codes(name, code));
            }
            return codes;
        }

        public class Country_Codes
        {

            public string Name;
            public string Code;

            public Country_Codes(string name, string code)
            {
                Name = name;
                Code = code;
            }
        }

        public static Config Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Config();
                    }
                    return instance;
                }
            }
        }
        public void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        public void load_engine_xml()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                String assembly_loc = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                doc.Load(assembly_loc + "/" + engine_file);
                List<EngineInfo> engineInfos = new List<EngineInfo>();
                XmlNode root = doc.DocumentElement;
                XmlNodeList google_apis = root.SelectNodes("google_api");
                foreach (XmlNode api in google_apis)
                {
                    XmlNodeList engineList = api.SelectNodes("engine");
                    EngineInfo engineInfo = new EngineInfo(api.Attributes.GetNamedItem("api").InnerText, engineList.Count);
                    int i = 0;
                    foreach (XmlNode node in engineList)
                    {
                        XmlNode filter_node = node.SelectSingleNode("filters");
                        List<string> filters = new List<string>();

                        if (filter_node != null) { 
                        XmlNodeList filterList = filter_node.SelectNodes("entry");
                        foreach (XmlNode filter in filterList)
                        {
                            filters.Add(filter.InnerText);
                        }
                        }
                        engineInfo.add_engine(i, new EngineInfo.Engine(node.SelectSingleNode("Title").InnerText, node.SelectSingleNode("cx").InnerText, filters));
                        i++;
                    }
                    engineInfos.Add(engineInfo);
                }
                Apis = engineInfos;
                first_time = false;
            }
            catch (Exception e)
            {
                first_time = true;
                MessageBox.Show(e.Message);
            }
        }

        internal List<EngineInfo> Apis { get => apis; set => apis = value; }

        internal void GenerateEnginesXML(List<EngineInfo> infos)
        {
            XmlWriter xmlWriter = XmlWriter.Create(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/" + "engines.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("document");
            foreach (EngineInfo engineInfo in infos)
            {
                xmlWriter.WriteStartElement("google_api");
                xmlWriter.WriteAttributeString("api", engineInfo.api_key);
                foreach (Engine engine in engineInfo.engines)
                {
                    xmlWriter.WriteStartElement("engine");
                    xmlWriter.WriteStartElement("Title");
                    xmlWriter.WriteString(engine.title);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("cx");
                    xmlWriter.WriteString(engine.cx);
                    xmlWriter.WriteEndElement();

                    if(engine.filters.Count != 0)
                    {
                        xmlWriter.WriteStartElement("filters");

                        foreach (string filter in engine.filters)
                        {
                            xmlWriter.WriteStartElement("entry");
                            xmlWriter.WriteString(filter);
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
