using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite.Linq;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace ThinkFTP.HelpClasses
{
    enum instanceMode {SingleFile, MultipleFIles};

    [Table(Name="Instances")]
    public class Instance
    {
        [Column(Name="id")]
        public int id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
        [Column(Name = "Address")]
        public string Address { get; set; }
        [Column(Name = "UserName")]
        public string UserName { get; set; }
        [Column(Name = "Library")]
        public string Library { get; set; }
        [Column(Name = "iSeriesFile")]
        public string iSeriesFile { get; set; }
        [Column(Name = "WindowsPath")]
        public string WindowsPath { get; set; }
        [Column(Name = "WindowsFile")]
        public string WindowsFile { get; set; }
        [Column(Name = "Mode")]
        public instanceMode Mode { get; set; }

        /// <summary>
        /// Fill the instance from a spicific XML Document
        /// </summary>
        /// <param name="XMLDocument">XML Document path/name</param>
        /// <param name="instanceID">Id of the instance as stored</param>
        public void getWithID(int instanceID)
        {
            var connection = new SQLiteConnection(@"Data Source=C:\ThinkFTPDatabase");

            using (var context = new DataContext(connection))
            {
                var data = from a in context.GetTable<Instance>()
                           where a.id == instanceID
                           select a;

                foreach (Instance selectedInstance in data)
                {
                    this.id = selectedInstance.id;
                    this.Name = selectedInstance.Name;
                    this.Address = selectedInstance.Address;
                    this.Library = selectedInstance.Library;
                    this.iSeriesFile = selectedInstance.iSeriesFile;
                    this.WindowsFile = selectedInstance.WindowsFile;
                    this.WindowsPath = selectedInstance.WindowsPath;
                    if (selectedInstance.Mode.Equals("S"))
                    {
                        this.Mode = instanceMode.SingleFile;
                    }
                    else
                    {
                        this.Mode = instanceMode.MultipleFIles;
                    }
                }

            }
        }

        public void saveNew(string XMLDocument)
        {

        }
    }
}
