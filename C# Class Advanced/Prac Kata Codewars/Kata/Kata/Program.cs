using System;

namespace Kata
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static int[] NoOdds(int[] values)
        {
            int[] number = new int[0];
            int counter = 0;

            foreach(int a in values)
            {
                if(a % 2 == 0)
                {
                    counter++;
                }
            }

            Array.Resize<int>(ref number, counter + 1);
            counter = 0;

            foreach (int a in values)
            {
                if (a % 2 == 0)
                {
                    number[counter] = a;
                    counter++;
                }
            }

            return number;
        }

        /* testing(Accumul.Accum("ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");*/
    }
}
