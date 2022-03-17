using System;

namespace CSharp_Basic_G2_If_Else_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            string varOne = Console.ReadLine();
            string varTwo = Console.ReadLine();

            int intOne = int.Parse(varOne);
            int intTwo = int.Parse(varTwo);

            if(intOne > intTwo)
            {
                Console.WriteLine($"{intOne} is bigger then {intTwo}");

                    if (intOne % 2 == 0)
                    {
                        Console.WriteLine($"{intOne} is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"{intOne} is an odd number");
                    }
            }

            else
            {
                Console.WriteLine($"{intTwo} is bigger then {intOne}");


                    if (intTwo % 2 == 0)
                    {
                        Console.WriteLine($"{intOne} is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"{intOne} is an odd number");
                    }
            }
        }
    }
}
