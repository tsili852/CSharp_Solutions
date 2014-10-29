using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SQLite.Linq;
using System.Data.SQLite;
using System.Data.Linq;


namespace ThinkFTP.HelpClasses
{
    static class HelpMe
    {
        public static List<Instance> getAllInstances()
        {
            List<Instance> list = new List<Instance>();

            var connection = new SQLiteConnection(@"Data Source=C:\ThinkFTPDatabase");

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
    }
}
