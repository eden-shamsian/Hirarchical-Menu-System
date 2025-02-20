using Ex04.Menus.Events;
using System.Collections.Generic;
using System;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private readonly MenuItem r_RootMenu;
        private List<MenuItem> m_CurrentItems;

        public MainMenu(MenuItem i_RootMenu)
        {
            r_RootMenu = i_RootMenu;
            m_CurrentItems = r_RootMenu.ListOfSubItems;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_RootMenu.AddSubItem(i_MenuItem);
        }

        private static void OnMenuItemSelected(MenuItem i_SelectedItem)
        {
            if (i_SelectedItem.ListOfSubItems.Count > 0)
            {
                Console.Clear();
            }
            else
            {
                i_SelectedItem.NotifySelection();
                Console.WriteLine();
            }
        }
       
        public void Show()
        {
            MenuItem currentMenu = r_RootMenu;
            string userInput;

            while (true)
            {
                Console.WriteLine($"** {currentMenu.MenuTitle} **\n--------------------------");
                for (int i = 0; i < currentMenu.ListOfSubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentMenu.ListOfSubItems[i].MenuTitle}");
                }

                if (currentMenu == r_RootMenu)
                {
                    Console.WriteLine("0. Exit");
                    Console.WriteLine($"Please enter your choice (1-{currentMenu.ListOfSubItems.Count} or 0 to exit):");
                }
                else
                {
                    Console.WriteLine("0. Back");
                    Console.WriteLine($"Please enter your choice (1-{currentMenu.ListOfSubItems.Count} or 0 to go back):");
                }

                Console.Write(">> ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int userChoice))
                {
                    if (userChoice == 0)
                    {
                        Console.Clear();
                        if (currentMenu == r_RootMenu)
                        {
                            Console.WriteLine("Exiting menu. Goodbye!");
                            break;
                        }
                        else
                        {
                            currentMenu = currentMenu.PreviousMenuItem;
                            m_CurrentItems = currentMenu.ListOfSubItems;
                        }
                    }
                    else if (userChoice >= 1 && userChoice <= m_CurrentItems.Count)
                    {
                        MenuItem selectedItem = m_CurrentItems[userChoice - 1];
                        if (selectedItem.ListOfSubItems.Count > 0)
                        {
                            currentMenu = selectedItem;
                            m_CurrentItems = selectedItem.ListOfSubItems;
                        }

                        OnMenuItemSelected(selectedItem);
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
