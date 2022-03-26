using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkProgram = "yes";

            while (checkProgram.ToLower() == "yes" || checkProgram.ToLower() == "y")
            {
                Console.WriteLine("Hello user can you please enter a number!");
                string numberStats = Console.ReadLine();
                bool numberStatsBool = double.TryParse(numberStats, out double numberStatsInt);

                if (numberStatsBool)
                {
                    NumberStats(numberStatsInt);
                }
                else
                {
                    Console.WriteLine("You didn't enter a valid number sir!");
                }

                Console.WriteLine("Do you want to run the program again? (Y)es or (N)o");
                checkProgram = Console.ReadLine();

                if(checkProgram.ToLower() != "yes" && checkProgram.ToLower() != "y" && checkProgram.ToLower() != "no" && checkProgram.ToLower() != "n")
                {
                    Console.WriteLine("Exiting the program you entered a wrong value!");
                    return;
                }
            }

            Console.WriteLine("Thank you for using our program!");
        }

        static void NumberStats(double check)
        {
            if(check > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if(check < 0)
            {
                Console.WriteLine("The number is negative!");
            }

            if(check % 2 == 0)
            {
                Console.WriteLine("The number is even!");
            }
            else if (check % 2 == 1)
            {
                Console.WriteLine("The number is odd!");
            }

            if(check % 1 == 0)
            {
                Console.WriteLine("The number is a whole number!");
            }
            else
            {
                Console.WriteLine("The number is a decimal!");
            }
        }
    }
}
