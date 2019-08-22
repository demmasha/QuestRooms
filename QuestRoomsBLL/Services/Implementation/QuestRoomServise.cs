using AutoMapper;
using QuestRoomsBLL.DtoModels;
using QuestRoomsBLL.Services.Abstraction;
using QuestRoomsDAL.Entities;
using QuestRoomsDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsBLL.Services.Implementation
{
    public class QuestRoomServis: IQuestRoomServise
    {
        private readonly IGenericRepository<Room> roomRepos;
        private readonly IMapper mapper;
        public QuestRoomServis(IGenericRepository<Room> _generic, IMapper _mapper)
        {
            roomRepos = _generic;
            mapper = _mapper;

        }
        public QuestRoomServis(IGenericRepository<Room> _roomRepos)
        {
            roomRepos = _roomRepos;
        }

    public ICollection<RoomDto> GetAllRoom()
        {
            var rooms = roomRepos.GetAll();
            return mapper.Map<IEnumerable<Room>, ICollection<RoomDto>>(rooms);

        }
    }
}
