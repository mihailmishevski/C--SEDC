using System;

namespace Prac_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(basicOp('+', 4, 7))*/
            Console.WriteLine(FakeBin("394859895823948523"));

        }

        /*        public static double basicOp(char operation, double value1, double value2)
                {
                    double result = 0;
                    switch (operation)
                    {
                        case '+':
                            result = value1 * value2;
                            break;

                        case '-':
                            result = value1 - value2;
                            break;

                        case '*':
                            result = value1 * value2;
                            break;

                        case '/':
                            result = value1 / value2;
                            break;
                    }
                    return result;
                }*/

        public static string FakeBin(string x)
        {
            string newString = "";
            int a = 0;

            for (int i = 0; i < x.Length; i++)
            {
                a = int.Parse(x[i].ToString());
                if(a < 5)
                {
                    newString += "0";
                    continue;
                }
                
                if(a >= 5)
                {
                    newString += "1";
                    continue;
                }
            }
            return newString;
            int num;
            num.ToString();
        }
    }
}
