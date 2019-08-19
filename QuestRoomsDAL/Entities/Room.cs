using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsDAL.Entities
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desctiptions { get; set; }        
        public TimeSpan Time { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int MinYears { get; set; }
        public virtual Address Address { get; set; }       
        public int NamberFone { get; set; }
        public string Email { get; set; }
        public virtual Company Company { get; set; }
        public int Rating { get; set; }
        public int Fear { get; set; }
        public int Level { get; set; }
        public string Logo { get; set; }
        public ICollection <Foto> Foto { get; set; }
    }
}
