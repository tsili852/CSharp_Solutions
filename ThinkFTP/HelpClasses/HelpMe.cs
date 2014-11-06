using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SQLite.Linq;
using System.Data.SQLite;
using System.Data.Linq;
using System.Transactions;
using ThinkFTP;


namespace ThinkFTP.HelpClasses
{
    static class MyTools
    {
        public static string dbPathWithoutFile;
        public static string dbPathWithFile;

        public static void fillSettings()
        {
            dbPathWithoutFile = ThinkFTP.Properties.Settings.Default.ApplicationPath;
            dbPathWithFile = dbPathWithoutFile + ThinkFTP.Properties.Settings.Default.DBName;
        }

        public static List<Instance> getAllInstances()
        {
            List<Instance> list = new List<Instance>();

            //var connection = new SQLiteConnection(@"Data Source=C:\ThinkFTPDatabase");
            var connection = new SQLiteConnection(@"Data Source=" + dbPathWithFile);

            using (var context = new DataContext(connection))
            {
                var data = from a in context.GetTable<Instance>()
                           select a;
                foreach (var inst in data)
                {
                    list.Add(inst);
                }
                return list;
            }
        }

        public static int getMaxID() 
        {
            var connection = new SQLiteConnection(@"Data Source=" + dbPathWithFile);

            using (var context = new DataContext(connection))
            {
                int maxID = (from a in context.GetTable<Instance>()
                             select a.id).Max();

                return maxID;
            }
        }

        public static void modifyInstance(Instance toBeModified)
        {
            using (var context = new InstanceContext())
            {
                var selectedInstance =
                    (from a in context.Instance
                     where a.id == toBeModified.id
                     select a).SingleOrDefault();

                selectedInstance.Address = toBeModified.Address;
                selectedInstance.iSeriesFile = toBeModified.iSeriesFile;
                selectedInstance.Library = toBeModified.Library;
                selectedInstance.Mode = toBeModified.Mode;
                selectedInstance.UserName = toBeModified.UserName;
                selectedInstance.WindowsFile = toBeModified.WindowsFile;
                selectedInstance.WindowsPath = toBeModified.WindowsPath;

                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static int saveNewInstance(Instance toBeSaved)
        {
            return 1;
        }

        public static void createDatabase()
        {
            SQLiteConnection.CreateFile(dbPathWithFile);

            SQLiteConnection dbConnection = new SQLiteConnection(@"Data Source=" + dbPathWithFile);
            dbConnection.Open();

            string sqlCreateInstances = @"CREATE TABLE [Instances] (
                                        [id] INTEGER NOT NULL PRIMARY KEY, 
                                        [Name] VARCHAR NOT NULL, 
                                        [Address] VARCHAR, 
                                        [UserName] VARCHAR, 
                                        [Library] VARCHAR, 
                                        [iSeriesFile] VARCHAR, 
                                        [WindowsPath] VARCHAR, 
                                        [WindowsFile] VARCHAR, 
                                        [Mode] CHAR(1));";

            //string sqlCreateIndex = @"CREATE UNIQUE INDEX [id] ON [Instances] ([id] ASC);";

            using (TransactionScope tran = new TransactionScope())
            {
                SQLiteCommand dbCommand = new SQLiteCommand(sqlCreateInstances, dbConnection);
                dbCommand.ExecuteNonQuery();

                //dbCommand.CommandText = sqlCreateIndex;
                //dbCommand.ExecuteNonQuery();

                tran.Complete();
            }

            dbConnection.Close();
        }

    }
}
