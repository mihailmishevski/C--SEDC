using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3] { 1, 3, 4 };
            int[] intArray2 = { 5, 6, 7 };

            Console.WriteLine(intArray[0]);

            for(int a = 0; a < intArray2.Length; a++)
            {
                Console.WriteLine(intArray2[a]);
            }

            string[] stringArray = { "One", "Two", "Three", "Four", "One" };
            int indexOfTwo = Array.IndexOf(stringArray, "Two");

            Console.WriteLine($"First appearence of two is {indexOfTwo}");

            int indexOfSix = Array.IndexOf(stringArray, "Six");
            Console.WriteLine($"First appearence of six is {indexOfSix}");

            bool[] boolArray = new bool[3];

            boolArray[0] = true;
            boolArray[1] = false;
            boolArray[2] = true;

            Array.Resize(ref boolArray, 6);

            boolArray[3] = false;

            Console.WriteLine(boolArray[3]);

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(Array.IndexOf(daysOfWeek, day));
                Console.WriteLine(day);
            }
        }
    }
}
