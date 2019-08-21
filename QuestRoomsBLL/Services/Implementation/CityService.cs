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
    public class CityService: ICityService
    {
        private readonly IGenericRepository<City> cityRepos;
        private readonly IMapper mapper;

        public CityService(IGenericRepository<City> _generic, IMapper _mapper)
        {
            cityRepos =_generic;
            mapper = _mapper;
            
        }
        public CityService(IGenericRepository<City> _cityRepos)
        {
            cityRepos = _cityRepos;
        }
        public ICollection<CityDto> GetAllCities()
        {
            var cities = cityRepos.GetAll();
            return mapper.Map<IEnumerable<City>, ICollection<CityDto>>(cities);
        }
        
    }
}
