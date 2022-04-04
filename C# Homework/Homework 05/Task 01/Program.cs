using System;
using System.Collections.Generic;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            bool keepNumbers = true;

            int counter = 1;

            Console.WriteLine("Please enter a number");

            string newNum = Console.ReadLine();
            bool newNumBool = int.TryParse(newNum, out int realNum);

            CheckQue(newNumBool, realNum, numbers);

            while (keepNumbers)
            {
                Console.WriteLine("Do you want to enter another number Yes/No?");
                string enterNumber = Console.ReadLine();

                if(enterNumber.ToLower() == "yes")
                {
                    Console.WriteLine("Please enter a number");
                    newNum = Console.ReadLine();
                    newNumBool = int.TryParse(newNum, out realNum);
                    CheckQue(newNumBool, realNum, numbers);
                }
                else
                {
                    Console.WriteLine("You pressed no or a different value - PRINTING!");
                    keepNumbers = false;
                }
            }

            while(numbers.Count > 0)
            {
                Console.WriteLine($"Number {counter} in the que is {numbers.Dequeue()}");
                counter++;
            }
        }

        static void CheckQue(bool check, int num, Queue<int> numbers)
        {
            if (!check)
            {
                Console.WriteLine("You didn't enter a number aborting!");
            }
            else
            {
                numbers.Enqueue(num);
            }
        }
    }
}
