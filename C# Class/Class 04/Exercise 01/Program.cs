using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers you want to add or subract!");
            int number1Int = ReadANumber();
            int number2Int = ReadANumber();

            Console.WriteLine("Do you want to add or subtract the numbers?");
            string sumOrSub = Console.ReadLine();

                switch (sumOrSub)
                {
                    case "+":
                        Console.WriteLine($"The addition of {number1Int} and {number2Int} is {Sum(number1Int, number2Int)}");
                        break;
                    case "-":
                        Console.WriteLine($"The subtract of {number1Int} and {number2Int} is {Subtract(number1Int, number2Int)}");
                        break;
                    default:
                        Console.WriteLine($"You didn't enter - or + - application is closing!");
                        break;
                }
            }


        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        static int ReadANumber()
        {
            Console.WriteLine("Enter enter a number");
            string number = Console.ReadLine();
            int.TryParse(number, out int parsedNumber);

            return parsedNumber;
        }
    }
}
