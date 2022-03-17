using System;

namespace CSharp_Basic_G2_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int intFirstNumber = int.Parse(firstNumber);
            int intSecondNumber = int.Parse(secondNumber);
            
            if (intFirstNumber > intSecondNumber)
            {
                Console.WriteLine(intFirstNumber + " is bigger then " + intSecondNumber);
            }
            else
            {
                Console.WriteLine(intSecondNumber + " is bigger then " + intFirstNumber);
            }
        }
    }
}
