using System;

namespace CSharp_Basic_G2_Input_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how much credit do you have?");
            string n = Console.ReadLine();
            Console.WriteLine("How much does one SMS cost?");
            string m = Console.ReadLine();

            int parseM = int.Parse(m);
            int parseN = int.Parse(n);
            int result = parseN / parseM;
            Console.WriteLine("You can send " + result + " messages!");
        }
    }
}
