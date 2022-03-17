using System;

namespace CSharp_Basic_G2_Switch_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    {
                        Console.WriteLine("You got a new car!");
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("You got a new plane!");
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("You got a new bike!");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("You entered a wrong character!");
                    }
                    break;
            }
        }
    }
}
