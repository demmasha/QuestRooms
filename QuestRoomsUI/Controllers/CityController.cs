using QuestRoomsBLL.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomsUI.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService cityService;
        public CityController(ICityService _cityService)
        {
            cityService = _cityService;
        }
        public string Index()
        {
            var cityes = cityService.GetAllCities();
            string res = "";
            foreach(var c in cityes)
            {
                res += $"{c.Name}<br>";
            }
            return  res;
        }
    }
}