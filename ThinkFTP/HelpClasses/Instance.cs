using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThinkFTP.HelpClasses
{
    enum instanceMode {SingleFile, MultipleFIles};

    class Instance
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Library { get; set; }
        public string iSeriesFile { get; set; }
        public string WindowsPath { get; set; }
        public string WindowsFile { get; set; }
        public instanceMode Mode { get; set; }

        /// <summary>
        /// Fill the instance from a spicific XML Document
        /// </summary>
        /// <param name="XMLDocument">XML Document path/name</param>
        /// <param name="instanceID">Id of the instance as stored</param>
        public void fillFromXML(string XMLDocument, int instanceID)
        {
            XDocument instDocument = XDocument.Parse(Properties.Resources.Instances);

            IEnumerable<XElement> properties = from props in instDocument.Descendants("Instance").Descendants("field")
                                               where props.Parent.Attribute("id").Value.Equals(Convert.ToString(instanceID))
                                               select props;

            foreach (XElement elem in properties)
            {
                string attribute = elem.Attribute("type").Value;
                Console.WriteLine("\nName: " + elem.Attribute("type").Value + "\nValue: " + elem.Value);
                if (attribute == "name")
                {
                    Name = elem.Value;
                }
                if (attribute == "serverAddress")
                {
                    Address = elem.Value; 
                }
                if (attribute == "userName")
                {
                    UserName = elem.Value;
                }
                if (attribute == "library")
                {
                    Library = elem.Value;
                }
                if (attribute == "iSeriesFile")
                {
                    iSeriesFile = elem.Value;
                }
                if (attribute == "windowsPath")
                {
                    WindowsPath = elem.Value;
                }
                if (attribute == "windowsFile")
                {
                    WindowsFile = elem.Value;
                }
                if (attribute == "mode")
                {
                    if (elem.Value == "S")
                    {
                        Mode = instanceMode.SingleFile;
                    }
                    else
	                {
                        Mode = instanceMode.MultipleFIles;
	                }
                }
            }
        }

        public void storeXML(string XMLDocument)
        {

        }
    }
}
