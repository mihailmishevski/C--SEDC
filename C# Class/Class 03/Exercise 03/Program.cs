using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number and we will do the math!");
            string newNumber = Console.ReadLine();
            bool realNewNumber = int.TryParse(newNumber, out int newNumberParsed);

            if (realNewNumber)
            {
                for (int a = 1; a <= newNumberParsed; a++)
                {
                    if (a % 3 == 0 || a % 7 == 0) 
                    {
                        continue;
                    }

                    if (a >= 100)
                    {
                        Console.WriteLine("You have reached the limit which is 100, the application will stop now!");
                        break;
                    }

                    Console.WriteLine(a);
                }
            }
        }
    }
}
