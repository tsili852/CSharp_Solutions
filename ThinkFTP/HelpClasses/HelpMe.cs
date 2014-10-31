using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SQLite.Linq;
using System.Data.SQLite;
using System.Data.Linq;
using System.Transactions;


namespace ThinkFTP.HelpClasses
{
    static class HelpMe
    {
        public static List<Instance> getAllInstances()
        {
            List<Instance> list = new List<Instance>();

            var connection = new SQLiteConnection(@"Data Source=B:\ThinkFTPDatabase");

            using (var context = new DataContext(connection))
            {
                var data = from a in context.GetTable<Instance>()
                           select a;

                foreach (Instance inst in data)
                {
                    list.Add(inst);
                }
                return list;
            }
        }

        public static void createDatabase(string dbPath)
        {
            SQLiteConnection.CreateFile(dbPath);

            SQLiteConnection dbConnection = new SQLiteConnection(@"Data Source=" + dbPath);
            dbConnection.Open();

            string sqlCreateInstances = @"CREATE TABLE [Instances] (
                                        [id] int, 
                                        [Name] varchar, 
                                        [Address] varchar, 
                                        [UserName] varchar, 
                                        [Library] varchar, 
                                        [iSeriesFile] varchar, 
                                        [WindowsPath] varchar, 
                                        [WindowsFile] varchar, 
                                        [Mode] char, 
                                            CONSTRAINT [] PRIMARY KEY ([id]));";

            string sqlCreateIndex = @"CREATE UNIQUE INDEX [id] ON [Instances] ([id] ASC);";

            using (TransactionScope tran = new TransactionScope())
            {
                SQLiteCommand dbCommand = new SQLiteCommand(sqlCreateInstances, dbConnection);
                dbCommand.ExecuteNonQuery();

                dbCommand.CommandText = sqlCreateIndex;
                dbCommand.ExecuteNonQuery();

                tran.Complete();
            }

            dbConnection.Close();
        }
    }
}
