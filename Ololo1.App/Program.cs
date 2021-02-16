using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input somethig");
            var something = Console.ReadLine();
            SimpleClass.CheckTextFromConsole(something);
        }
    }
}