using System;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] intArray = new int[6];
            for(int a = 1; a < intArray.Length; a++)
            {
                Console.WriteLine($"Enter number {a} that you want to join the array!");
                string text = Console.ReadLine();
                
                bool textArray = int.TryParse(text, out int textArrayParsed);

                if (textArray)
                {
                    intArray[a] = textArrayParsed;
                }

                result += intArray[a];
            }
            Console.WriteLine($"The result of all the numbers in the array is {result}!");
        }
    }
}
