﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex04.Menus.Interfaces
{
    public interface IMenuListener
    {
        void OnMenuItemSelected(MenuItem i_SelectedItem);
    }
}
