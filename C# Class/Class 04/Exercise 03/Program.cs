using System;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadANumber();
            string newSentance = Substrings();
            string newSentanceSub = newSentance.Substring(0, number);

            Console.WriteLine(newSentanceSub);
            Console.WriteLine(newSentanceSub.Length);
        }

        static string Substrings()
        {
            string sentence = "Hello from SEDC Codeacademy 2021";
            return sentence;
        }

        static int ReadANumber()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int.TryParse(number, out int parsedNumber);

            return parsedNumber;
        }
    }
}
