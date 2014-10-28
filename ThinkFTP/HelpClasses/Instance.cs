using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

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
            XDocument instDocument = XDocument.Load(Properties.Resources.Instances);

            IEnumerable<XElement> properties = from props in instDocument.Elements("Instance")
                                               where (int)props.Attribute("id") == instanceID
                                               select props;

            foreach (var elem in properties)
            {
                Console.WriteLine("Name: " + elem.Name + " Value: " + elem.Value);
            }
        }

        public void saveInstanceToXML(string XMLDocument)
        {
            XDocument instaDocument = XDocument.Load(XMLDocument);


        }
    }
}
