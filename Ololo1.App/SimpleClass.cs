using System;

namespace ConsoleApp1
{
    public class SimpleClass
    {
        public static bool CheckTextFromConsole(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("You haven't not entered anything");
                return false;
            }
            else
            {
                Console.WriteLine("You entered: " + text);
                return true;
            }
        }
    }
}