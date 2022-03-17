using System;

namespace CSharp_Homework_01_Mihail_Mishevski_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4 digits to find out their average!");
            string firstDigit = Console.ReadLine();
            string secondDigit = Console.ReadLine();
            string thirdDigit = Console.ReadLine();
            string fourthDigit = Console.ReadLine();

            /*            double firstIntDigit = double.Parse(firstDigit);
                        double secondIntDigit = double.Parse(secondDigit);
                        double thirdIntDigit = double.Parse(thirdDigit);
                        double fourthIntDigit = double.Parse(fourthDigit);*/

            bool boolFirstDigitCheck = double.TryParse(firstDigit, out double firstIntDigit);
            bool boolSecondDigitCheck = double.TryParse(secondDigit, out double secondIntDigit);
            bool boolThirdDigitCheck = double.TryParse(thirdDigit, out double thirdIntDigit);
            bool boolFourthDigitCheck = double.TryParse(fourthDigit, out double fourthIntDigit);

            if(boolFirstDigitCheck && boolSecondDigitCheck && boolThirdDigitCheck && boolFourthDigitCheck) 
            { 
                    double addDigits = firstIntDigit + secondIntDigit + thirdIntDigit + fourthIntDigit;
                    double averageDigits = addDigits / 4;

                if (addDigits == 0)
                {
                    Console.WriteLine("You can not find average of 0, please enter at least one non zero value!");
                }
                else
                {
                    Console.WriteLine($"The average of the four digits you entered is {averageDigits}");
                }
            }
            else
            {
                Console.WriteLine("You entered a non digit value - shutting down!");
            }
        }
    }
}
