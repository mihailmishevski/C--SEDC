using System;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];

            for(int a = 0; a < names.Length; a++)
            {
                Console.WriteLine("Enter a name please!");

                string name = Console.ReadLine();
                names[a] = name;

                Console.WriteLine("Do you want to enter another name press Y for yes, and N for no!");
                string yesOrNo = Console.ReadLine();

                if (yesOrNo == "y")
                {
                    continue;
                }
                else if (yesOrNo == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered something wrong!");
                }
            }

            foreach (string print in names)
            {
                Console.WriteLine(print);
            }
        }
    }
}
