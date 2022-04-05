using System;
using System.Collections.Generic;

namespace Prac_01
{
    class Program
    {
        static void Main(string[] args)
        {
            static int NbYear(int p0, double percent, int aug, int p)
            {
                int years = 0;
                double p0double = Convert.ToDouble(p0);
                double augDouble = Convert.ToDouble(aug);
                double pDouble = Convert.ToDouble(p);

                while (pDouble > p0double)
                {
                    p0double += p0double * percent + augDouble;
                    years += 1;
                }

                return years;
            }

            Console.WriteLine(NbYear(1500, 5, 100, 5000));
        }
    }
}

