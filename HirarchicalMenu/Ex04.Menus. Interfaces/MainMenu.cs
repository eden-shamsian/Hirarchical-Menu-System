using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex04.Menus.Interfaces
{
    public class MainMenu : IMenuListener
    {
        private readonly MenuItem r_RootMenu;

        public MainMenu(MenuItem i_RootMenu)
        {
            r_RootMenu = i_RootMenu;
        }

        public MenuItem RootMenu
        {
            get { return r_RootMenu; }
        }

        public void OnMenuItemSelected(MenuItem i_SelectedItem)
        {
            if (i_SelectedItem.SubItems.Count > 0)
            {
                Console.Clear();
            }
            else if (i_SelectedItem.Action != null)
            {
                i_SelectedItem.Action.Execute();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No action available for this item.");
            }
        }

        public void Show()
        {
            MenuItem currentMenu = r_RootMenu;
            string userInput;

            while (true)
            {
                Console.WriteLine($"** {currentMenu.MenuTitle} **\n--------------------------");
                for (int i = 0; i < currentMenu.SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentMenu.SubItems[i].MenuTitle}");
                }

                if (currentMenu == r_RootMenu)
                {
                    Console.WriteLine("0. Exit");
                    Console.WriteLine($"Please enter your choice (1-{currentMenu.SubItems.Count} or 0 to exit):");
                }
                else
                {
                    Console.WriteLine("0. Back");
                    Console.WriteLine($"Please enter your choice (1-{currentMenu.SubItems.Count} or 0 to go back):");
                }

                Console.Write(">> ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int userChoice))
                {
                    if (userChoice == 0)
                    {
                        Console.Clear();
                        if (currentMenu.PreviousMenuItem != null)
                        {
                            currentMenu = currentMenu.PreviousMenuItem;
                        }
                        else
                        {
                            Console.WriteLine("Exiting menu. Goodbye!");
                            break;
                        }
                    }
                    else if (userChoice >= 1 && userChoice <= currentMenu.SubItems.Count)
                    {
                        MenuItem selectedItem = currentMenu.SubItems[userChoice - 1];

                        if (selectedItem.SubItems.Count > 0)
                        {
                            currentMenu = selectedItem;
                        }

                        selectedItem.NotifySelection();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}