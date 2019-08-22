using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsBLL.DtoModels
{
    public class RoomDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desctiptions { get; set; }
        public TimeSpan Time { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int MinYears { get; set; }       
        public string NamberFone { get; set; }
        public string Email { get; set; }      
        public int Rating { get; set; }
        public int Fear { get; set; }
        public int Level { get; set; }
        public string Logo { get; set; }
      
    }
}
