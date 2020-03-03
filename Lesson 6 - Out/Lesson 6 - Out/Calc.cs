using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6___Out
{
    static class Calc
    {

        public static void Plus(out int result, params int[] digits )
        {
            result = digits.Sum();
        }

        public static void Minus(out int result, params int[] digits)
        {
            result = digits[0];
            for (int i = 0; i < digits.Length; i++)
            {
                if (i > 0)             
                    result = (result - digits[i]);              
            }
        }


        public static void Multiple(out int result, params int[] digits)
        {
            result = digits[0];
            for (int i = 0; i < digits.Length; i++)
            {
                if (i > 0)
                    result = (result * digits[i]);
            }
        }
        public static void Division(out int result, params int[] digits)
        {
            result = digits[0];
            for (int i = 0; i < digits.Length; i++)
            {
                if (i > 0)
                    result = (result / digits[i]);
            }
        }

    }
}
