using System;

namespace DatesAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteNumberMessage();

            int number = ReadANumber();
            Console.WriteLine($"The number you have netered is {number}");

            for(int a = 1; a < number; a++)
            {
                if (IsEvenNumber(a))
                {
                    Console.WriteLine(a);
                }
            }
        }

        static int ReadANumber()
        {
            Console.WriteLine("Enter enter a number");
            string number = Console.ReadLine();
            int.TryParse(number, out int parsedNumber);

            return parsedNumber;
        }

        static void WriteNumberMessage()
        {
            Console.WriteLine("Please enter a number");
        }

        static bool IsEvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
