using AutoMapper;
using QuestRoomsBLL.DtoModels;
using QuestRoomsDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsBLL.Mapping
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<Foto, FotoDto>();
            CreateMap<Street, StreetDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Address, AddressesDto>();
            CreateMap<Room, RoomDto>();
        }
    }
}
