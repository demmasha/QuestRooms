using QuestRoomsBLL.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomsUI.Controllers
{
    public class QuestRoomController : Controller
    {
        private readonly IQuestRoomServise roomService;
        public QuestRoomController(IQuestRoomServise _roomService)
        {
            roomService = _roomService;
        }
        public ViewResult Index()
        {
            var room = roomService.GetAllRoom();
            //string res = "";
            //foreach (var c in room)
            //{
            //    res += $"{c.Name}+{c.Time}+{c.Desctiptions}+{c.Email}<br>";
            //}
            return View();
        }
    }
}