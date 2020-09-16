using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Timer
{
   public class ReadFile
    {
        FileHelper log = new FileHelper();

        public string getdatanode(string nodename,string path)
        {
            try 
            {
                XmlNodeList xmln_duplicate;
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\config.xml");
                xmln_duplicate = doc.GetElementsByTagName(nodename); // Get lef to right Node   doc.GetElementsByTagName("");
                string patch = xmln_duplicate[0].InnerText;
                return patch;
            }
            catch (Exception ex) 
            {
                log.writelog(path, "getdatanode", "Exception ------ " + ex.ToString());
                return "";
            }
           
        }
    }
}
