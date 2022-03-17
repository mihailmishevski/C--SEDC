using System;

namespace CSharp_Homework_02_Mihail_Mishevski_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] arraySix = new int[6];

            Console.WriteLine("Please enter 6 whole numbers for the calculation!");

            for (int a = 0; a < arraySix.Length; a++)
            {
                string enteredNumber = Console.ReadLine();
                bool boolEnteredNumber = int.TryParse(enteredNumber, out int realEnteredNumber);

                if (boolEnteredNumber)
                {
                    arraySix[a] = realEnteredNumber;
                }
                else
                {
                    Console.WriteLine("You entered a non digit character will skip this row!");
                    a--;
                }


                if (arraySix[a] % 2 == 0)
                {
                    result += arraySix[a];
                }
            }

            Console.WriteLine($"The sum of the numbers you entered is {result}");
        }
    }
}
