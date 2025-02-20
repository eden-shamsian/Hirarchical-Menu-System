using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex04.Menus.Test
{
    public class MenusInterfacesTest
    {
        private readonly MainMenu r_MenuManager;

        public MenusInterfacesTest()
        {
            r_MenuManager = InitializeMenu();
        }

        public MainMenu InitializeMenu()
        {
            MainMenu mainMenu = new MainMenu(new MenuItem("Interface Main Menu"));
            MenuItem lettersAndVersionMenu = new MenuItem("Letters and Version", null, mainMenu);
            lettersAndVersionMenu.AddSubItem(new MenuItem("Show Version", new ShowVersionAction(), mainMenu));
            lettersAndVersionMenu.AddSubItem(new MenuItem("Count Lowercase Letters", new CountLowercaseLettersAction(), mainMenu));
            MenuItem dateTimeMenu = new MenuItem("Show Current Date/Time", null, mainMenu);
            dateTimeMenu.AddSubItem(new MenuItem("Show Current Time", new ShowCurrentTimeAction(), mainMenu));
            dateTimeMenu.AddSubItem(new MenuItem("Show Current Date", new ShowCurrentDateAction(), mainMenu));
            mainMenu.RootMenu.AddSubItem(lettersAndVersionMenu);
            mainMenu.RootMenu.AddSubItem(dateTimeMenu);

            return mainMenu;
        }

        public void ShowMainMenu()
        {
            r_MenuManager.Show();
        }
    }
}