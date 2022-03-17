using System;

namespace CSharp_Basic_G2_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare integers
            int a = 0;
            int variableOne = 1;
            int variableTwo = 2;
            int result = variableOne + variableTwo;
            decimal decimalVariableOne = 1.5m;
            decimal decimalVariableTwo = 2.5m;
            decimal resultDecimal = decimalVariableOne - decimalVariableTwo;
            decimal resultMultiDecimal = decimalVariableOne * decimalVariableTwo;
            decimal resultDivDecimal = decimalVariableOne / decimalVariableTwo;
            double averageScore = 3.5;
            bool isActive = true;
            bool isBusy = false;
            bool boolVariableOne = true;
            bool boolvariableTwo = false;
            bool resultBool = boolVariableOne && boolvariableTwo;
            bool resultBoolOr = boolVariableOne || boolvariableTwo;
            
            a = 2;
            averageScore = a;
            char chosenLetter = 'a';
            string helloWorld = "Hello World";
            DateTime date = new DateTime(2022, 3, 10, 18, 12, 15);

            Console.WriteLine(averageScore);
            Console.WriteLine(a);
            Console.WriteLine(date);
            Console.WriteLine(chosenLetter);
            Console.WriteLine(helloWorld);
            Console.WriteLine(result);
            Console.WriteLine(variableOne + variableTwo);
            Console.WriteLine(resultDecimal);
            Console.WriteLine(resultMultiDecimal);
            Console.WriteLine(resultDivDecimal);
            Console.WriteLine(resultBool);
            Console.WriteLine(resultBoolOr);

            // a = true && b = true => true
            // a = true && b = false => false
            // a = false && b = false => false
            // a = false && b = true = > false

            // a = true || b = true => true
            // a = true || b = false => true
            // a = false || b = true => true
            // a = false || b = false => false
        }
    }
}
