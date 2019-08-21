using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace QuestRoomsDAL.Configuration
{
   public  class DbInitializer : DropCreateDatabaseAlways<RoomsContext>
    {

        protected override void Seed(RoomsContext context)
        {
            var dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath+ @"/MockData/Cities.sql"));
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath + @"/MockData/Countries.sql"));
        }

        public string ReadFromFile(string v)
        {
            using (StreamReader sr = new StreamReader(v))
            {
                return sr.ReadToEnd();
            }
        }

       
    }
}
