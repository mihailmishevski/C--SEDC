using System;

namespace CSharp_Homework_02_Mihail_Mishevski_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentGroup1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentGroup2 = { "Zoki", "Mile", "Brus", "Petko", "Vele" };

            Console.WriteLine("Please enter if group 1 or 2 should be printed out!");

            string enteredValue = Console.ReadLine();

            bool boolEnteredValue = int.TryParse(enteredValue, out int enteredValueInt);

            if (boolEnteredValue)
            {
                switch (enteredValueInt)
                {
                    case 1:
                        foreach (string student1 in studentGroup1)
                        {
                            Console.WriteLine(student1);
                        }
                        break;

                    case 2:
                        foreach (string student2 in studentGroup2)
                        {
                            Console.WriteLine(student2);
                        }
                        break;

                    default:
                        Console.WriteLine("You entered neither 1 or 2 please try again :(");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You entered neither 1 or 2 nor a digit :( sad!");
            }
        }
    }
}
