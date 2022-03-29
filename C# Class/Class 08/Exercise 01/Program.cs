using System;
using System.Collections.Generic;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                { "Bazho", "071-224-204" },
                { "Mihail", "072-224-204" },
                { "Random", "000-000-000" }
            };

            Console.WriteLine("Check your phonebook!");
            string check = Console.ReadLine();

            if (phoneBook.ContainsKey(check))
            {
                Console.WriteLine($"His number is {phoneBook[check]}");
            }
            else
            {
                Console.WriteLine("Person not found!");
            };
        }
    }
}
