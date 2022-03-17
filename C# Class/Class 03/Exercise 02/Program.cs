using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number so we can print all the even numbers for you until we reach that number!");
            string evenNumber = Console.ReadLine();
            bool checkEvenNumber = int.TryParse(evenNumber, out int evenNumberParsed);

            if (checkEvenNumber)
            {
                for(int a = 2; a <= evenNumberParsed; a = a + 2)
                {
                    Console.WriteLine(a);
                }
            }

            Console.WriteLine("Enter any number so we can print all the odd numbers for you until we reach that number!");
            string oddNumber = Console.ReadLine();
            bool checkOddNumber = int.TryParse(evenNumber, out int oddNumberParsed);

            if (checkOddNumber)
            {
                for(int b = 1; b <= oddNumberParsed; b = b + 2)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
