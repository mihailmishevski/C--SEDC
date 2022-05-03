using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Utils
{
    public static class IntegerUtils
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsBiggerThan(this int numberOne, int numberTwo)
        {
            return numberOne > numberTwo;
        }
    }
}
