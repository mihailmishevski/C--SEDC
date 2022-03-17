using System;

namespace CSharp_Homework_01_Mihail_Mishevski_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers and the operation +,-,*,/, that you want to execute!");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string operation = Console.ReadLine();

            bool boolIntFirstNumber = int.TryParse(firstNumber, out int intFirstNumber);
            bool boolIntSecondNumber = int.TryParse(secondNumber, out int intSecondNumber);
            int result;

            if (boolIntFirstNumber && boolIntSecondNumber)
            {
                switch (operation)
                {
                    case "+":
                        {
                            result = intFirstNumber + intSecondNumber;
                            Console.WriteLine($"Addition of the numbers {intFirstNumber} and {intSecondNumber} is {result}");
                        }
                        break;

                    case "-":
                        {
                            result = intFirstNumber - intSecondNumber;
                            Console.WriteLine($"Subtraction of the numbers {intFirstNumber} and {intSecondNumber} is {result}");
                        }
                        break;

                    case "/":
                        {
                            result = intFirstNumber / intSecondNumber;
                            Console.WriteLine($"Division of the numbers {intFirstNumber} and {intSecondNumber} is {result}");
                        }
                        break;

                    case "*":
                        {
                            result = intFirstNumber * intSecondNumber;
                            Console.WriteLine($"Multiplication of the numbers {intFirstNumber} and {intSecondNumber} is {result}");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("You entered an invalid operation, please try again!");
                        }
                        break;
                }
            }
        }
    }
}
