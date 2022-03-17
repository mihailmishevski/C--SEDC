using System;

namespace CSharp_Homework_01_Mihail_Mishevski_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers so we can switch them around sir!");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string placeHolder;

            Console.WriteLine($"The first digit you entered is {firstNumber} and the second digit you entered is {secondNumber}.");

            Console.WriteLine("******PROCESSING******");

            placeHolder = secondNumber;
            secondNumber = firstNumber;
            firstNumber = placeHolder;

            Console.WriteLine($"The switched digits are!!! First digit is {firstNumber} and the second digit is {secondNumber}.");
        }
    }
}
