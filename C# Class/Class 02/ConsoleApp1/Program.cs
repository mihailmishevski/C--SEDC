using System;

namespace CSharp_Basic_G2_L2_Input_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            string numberThree = Console.ReadLine();
            int numberOneParsed = int.Parse(numberOne);
            int numberTwoParsed = Convert.ToInt32(numberTwo);
            bool parsingResult = int.TryParse(numberThree, out int numberThreeParsed);

            Console.WriteLine(numberOne + " " + numberTwo + " " + numberThree);
            Console.WriteLine(numberOneParsed + numberTwoParsed + numberThreeParsed);
        }
    }
}
