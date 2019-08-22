using QuestRoomsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomsContext context = new RoomsContext();
            foreach(var c in context.Rooms)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
