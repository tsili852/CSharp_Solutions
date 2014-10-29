using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite.Linq;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data.Linq;

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
        public void getWithID(int instanceID)
        {
            var connection = new SQLiteConnection(@"Data Source=ThinkFTPDatabase");
            var context = new DataContext(connection);

            var instances = context.GetTable<Instance>();
            foreach (var instance in instances)
            {
                Console.WriteLine(instance.Address + " " + instance.iSeriesFile);
            }
            //using (var context = new InstanceContext())
            //{
            //    var data = from a in context.Instance
            //               //where a.id == instanceID
            //               select a;

            //    foreach (var instance in data)
            //    {
            //        Console.WriteLine(instance.Library);
            //    }
            //}

        }

        public void saveNew(string XMLDocument)
        {

        }
    }
}
