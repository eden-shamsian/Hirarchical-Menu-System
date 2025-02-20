using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    // $G$ DSN-999 (0) Bad encapsulation. These methods should have been internal.
    public class Methods
    {
        public static void ShowCurrentDateAction()
        {
            string formattedDate = DateTime.Now.ToString("d", CultureInfo.CurrentCulture);
            Console.WriteLine($"> Current Date: {formattedDate}");
        }

        public static void ShowCurrentTimeAction()
        {
            Console.WriteLine($"Current Time: {DateTime.Now:HH:mm:ss}");
        }

        public static void CountLowercaseLettersAction()
        {
            string input = Console.ReadLine();
            int count = input.Count(char.IsLower);
            Console.WriteLine($"> There are {count} lowercase letters in your text.");
        }

        public static void ShowVersionAction()
        {
            Console.WriteLine("App Version: 25.1.4.5480");
        }
    }
}  