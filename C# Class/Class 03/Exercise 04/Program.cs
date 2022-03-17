using System;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayString = { "Hey", "How", "Are", "You", "Today?" };
            decimal[] arrayDecimal = { 5.1m, 6.2m, 20.3m, 5.4m, 19.5m };
            char[] charArray = { 'a', 'b', 'c', 'd', 'g' };
            bool[] arrayBool = { true, false, true, true, true };
            int[,] arrayArray = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            int[][] arrayArrayV2 =
            {
                new int[] {1,0},
                new int[] {3,6},
                new int[] {4,8},
                new int[] {10,20},
                new int[] {4,9}
            };

            foreach (int[] array in arrayArrayV2)
            {
                foreach(int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
