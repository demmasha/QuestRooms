using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsDAL.Entities
{
   public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        ICollection<Address> addresses { get; set; }
    }
}
