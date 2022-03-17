using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number that you want to count to!");
            string number = Console.ReadLine();
            int realNumber = int.Parse(number);

            for (int a = 1; a <= realNumber; a++)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Enter any number that you want to count to!");
            string numberTwo = Console.ReadLine();
            int realNumberTwo = int.Parse(numberTwo);
            for (int b = realNumberTwo; b >= 1; b--)
            {
                Console.WriteLine(b);
            }
        }
    }
}
