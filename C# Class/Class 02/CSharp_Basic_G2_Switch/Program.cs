using System;

namespace CSharp_Basic_G2_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    {
                        Console.Write("You pressed the button a");
                    }
                    break;

                case "b":
                    {
                        Console.WriteLine("You pressed the button b");
                    }
                    break;

                case "c":
                    {
                        Console.WriteLine("You pressed the button c");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Nothing has been entered");
                    }
                    break;
            }
        }
    }
}
