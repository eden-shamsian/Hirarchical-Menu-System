using Ex04.Menus.Events;
using Ex04.Menus.Test;
using System;
using System.Globalization;
using System.Linq;
public class MenusEventsTest
{
    private readonly MainMenu r_MenuManager;

    public MenusEventsTest()
    {
        r_MenuManager = InitializeMenu();
    }

    public MainMenu InitializeMenu()
    {
        MenuItem rootMenu = new MenuItem("Delegates Main Menu");
        MainMenu mainMenu = new MainMenu(rootMenu);
        MenuItem lettersAndVersionMenu = new MenuItem("Letters and Version");
        MenuItem showVersion = new MenuItem("Show Version");
        showVersion.OnItemSelected += Methods.ShowVersionAction;
        MenuItem countLowercase = new MenuItem("Count Lowercase Letters");
        countLowercase.OnItemSelected += Methods.CountLowercaseLettersAction;
        lettersAndVersionMenu.AddSubItem(showVersion);
        lettersAndVersionMenu.AddSubItem(countLowercase);
        MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");
        MenuItem showTime = new MenuItem("Show Current Time");
        showTime.OnItemSelected += Methods.ShowCurrentTimeAction;
        MenuItem showDate = new MenuItem("Show Current Date");
        showDate.OnItemSelected += Methods.ShowCurrentDateAction;
        showDateTimeMenu.AddSubItem(showTime);
        showDateTimeMenu.AddSubItem(showDate);
        mainMenu.AddMenuItem(lettersAndVersionMenu);
        mainMenu.AddMenuItem(showDateTimeMenu);

        return mainMenu;
    }

    public void ShowMainMenu()
    {
        r_MenuManager.Show();
    }
}
