﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsDAL.Entities
{
   public class Address
    {
        public int ID { get; set; }
        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
        public virtual Street Street { get; set; }
        public string HouseNumber { get; set; }
        ICollection<Room> Rooms { get; set; }

    }
}
