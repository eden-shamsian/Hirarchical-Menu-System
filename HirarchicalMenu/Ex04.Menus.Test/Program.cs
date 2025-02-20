
using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MenusInterfacesTest test1 = new MenusInterfacesTest();
            test1.ShowMainMenu();
            Console.Clear();
            MenusEventsTest test2 = new MenusEventsTest();
            test2.ShowMainMenu();
        }
    }
}
