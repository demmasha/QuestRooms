using QuestRoomsBLL.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsBLL.Services.Abstraction
{
    public interface IQuestRoomServise
    {
        ICollection<RoomDto> GetAllRoom();
    }
}
