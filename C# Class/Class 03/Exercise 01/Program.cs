using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number that you want to count to!");
            string number = Console.ReadLine();
            bool realNumber = int.TryParse(number, out int realNumberParsed);

            if (realNumber)
            {
                for (int a = 1; a <= realNumberParsed; a++)
                {
                    Console.WriteLine(a);
                }
            }


            Console.WriteLine("Enter any number that you want to count to!");
            string numberTwo = Console.ReadLine();
            bool realNumberTwo = int.TryParse(numberTwo, out int realNumberTwoParsed);

            if (realNumberTwo) 
            { 
                for (int b = realNumberTwoParsed; b >= 1; b--)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
