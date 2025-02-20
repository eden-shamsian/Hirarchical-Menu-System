using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex04.Menus.Test
{
    internal class CountLowercaseLettersAction : IMenuAction
    {
        public void Execute()
        {
            Methods.CountLowercaseLettersAction();
        }
    }
}
