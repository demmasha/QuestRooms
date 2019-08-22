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
            var dirPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\bin\MockData\";
            
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath+ "Cities.sql"));
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath + "Countries.sql"));
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath + "Streets.sql"));
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath + "Addresses.sql"));
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath + "Companies.sql"));
            context.Database.ExecuteSqlCommand(ReadFromFile(dirPath + "Rooms.sql"));

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
