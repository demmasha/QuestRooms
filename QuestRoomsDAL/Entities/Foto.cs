using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsDAL.Entities
{
   public class Foto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Room Room { get; set; }
    }
}
