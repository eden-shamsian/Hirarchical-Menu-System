using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowCurrentDateAction : IMenuAction
    { 
        public void Execute()
        {
            Methods.ShowCurrentDateAction();
        }
    }
}
