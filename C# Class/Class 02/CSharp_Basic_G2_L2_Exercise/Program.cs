using System;

namespace CSharp_Basic_G2_L2_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleVariableOne = 5;
            double doubleVariableTwo = 6;
            double doubleResult = doubleVariableOne / doubleVariableTwo;

            string stringVariableOne = "Hello ";
            string stringVariableTwo = "Sir";
            string stringResult = stringVariableOne + stringVariableTwo;

            string stringVariableThree = "9";
            string stringVariableFour = "3";
            string stringResultNumber = stringVariableThree + stringVariableFour;

            int intVariableOne = 9;
            int intVariableTwo = 3;
            int intResult = intVariableOne / intVariableTwo;

            Console.WriteLine(Math.Round((doubleResult), 2));
            Console.WriteLine(intResult);
            Console.WriteLine(stringResult);
            Console.WriteLine(stringResultNumber);
        }
    }
}
