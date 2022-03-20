using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello " + "World";
            int classNumber = 4;
            string secondString = $"This is class number {classNumber}";
            string thirdString = string.Format("First Parameter: {0}. Second Parameter: {1}", 34, classNumber);

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.WriteLine(thirdString);

            decimal decimalNumber = 3.5435367235m;
            Console.WriteLine(string.Format("{0:N2}", decimalNumber));

            decimal price = 99.9m;
            Console.WriteLine(string.Format("The price is {0:C}", price));

            decimal discount = 1.5m;
            Console.WriteLine(string.Format("The discount is {0:P}", discount));

            Console.WriteLine(string.Format("Phone number: {0:###-###-###}", 070123456));

            string text = "This is C# Basic, Class Number 04";
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.Write(text.Trim());
            Console.WriteLine(text.Length);

            bool startsWith = text.StartsWith("This");

            int indexOfCl = text.IndexOf("Cl");

            Console.WriteLine(startsWith);

            Console.WriteLine(indexOfCl);

            Console.WriteLine(text[0]);

            string courseTitle = text.Substring(8, 8);
            Console.WriteLine(courseTitle);

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
