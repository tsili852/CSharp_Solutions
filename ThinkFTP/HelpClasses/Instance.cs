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
    public enum instanceMode {SingleFile, MultipleFIles};

    [Table(Name="Instances")]
    public class Instance
    {
        private int _id;
        private string _name;
        private string _address;
        private string _usernName;
        private string _library;
        private string _400File;
        private string _windowsPath;
        private string _windowsFile;
        [Column(Name = "Mode")]
        private char _mode;

        [Column(Name="id")]
        public int id
        { 
            get 
            {
                return _id;
            }
            set 
            {
                _id = value;
            }
        }
        [Column(Name = "Name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        [Column(Name = "Address")]
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        [Column(Name = "UserName")]
        public string UserName
        {
            get
            {
                return _usernName;
            }
            set
            {
                _usernName = value;
            }
        }
        [Column(Name = "Library")]
        public string Library
        {
            get
            {
                return _library;
            }
            set
            {
                _library = value;
            }
        }
        [Column(Name = "iSeriesFile")]
        public string iSeriesFile
        {
            get
            {
                return _400File;
            }
            set
            {
                _400File = value;
            }
        }
        [Column(Name = "WindowsPath")]
        public string WindowsPath
        {
            get
            {
                return _windowsPath;
            }
            set
            {
                _windowsPath = value;
            }
        }
        [Column(Name = "WindowsFile")]
        public string WindowsFile
        {
            get
            {
                return _windowsFile;
            }
            set
            {
                _windowsFile = value;
            }
        }
        public instanceMode Mode
        {
            get
            {
                if (_mode == 'S')
                {
                    return instanceMode.SingleFile;
                }
                else
                {
                    return instanceMode.MultipleFIles;
                }
            }
            set
            {
                if (value == instanceMode.SingleFile)
                {
                    _mode = 'S';
                }
                else
                {
                    _mode = 'M';
                }
            }
        }

        /// <summary>
        /// Fill the instance from a spicific XML Document
        /// </summary>
        /// <param name="XMLDocument">XML Document path/name</param>
        /// <param name="instanceID">Id of the instance as stored</param>
        /// <exception cref="InstanceNotFoundException">Thrown when the selected instance was not found</exception>
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
                    this.UserName = selectedInstance.UserName;
                    this.Address = selectedInstance.Address;
                    this.Library = selectedInstance.Library;
                    this.iSeriesFile = selectedInstance.iSeriesFile;
                    this.WindowsFile = selectedInstance.WindowsFile;
                    this.WindowsPath = selectedInstance.WindowsPath;
                    this.Mode = selectedInstance.Mode;
                }

                if (data.Count<Instance>() == 0)
                {
                    throw new InstanceNotFoundException("Selected instance not found in database");
                }
            }
        }
    }
}
