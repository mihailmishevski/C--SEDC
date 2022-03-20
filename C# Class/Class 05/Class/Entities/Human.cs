using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Entities
{
    internal class Human
    {
        public string FirstName;

        public string LastName;

        public int Age;

        public void GetPersonStats()
        {
            Console.WriteLine($"His name is {FirstName} his last name is {LastName} and he is {Age} old!");
        }
    }
}
