using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6___Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of digits: ");
            int size = int.Parse(Console.ReadLine());

            int[] digits = new int[size];

            for (int i = 0; i < digits.Length; i++)
            {
                Console.WriteLine("Enter digit N{0}", i+1);
                digits[i] = int.Parse(Console.ReadLine());
            }
        
            Calc.Plus(out int sum, digits);
            Calc.Minus(out int difference, digits);
            Calc.Multiple(out int mult, digits);
            Calc.Division(out int div, digits);

            Console.WriteLine("SUM = "+ sum);
            Console.WriteLine("DIF = "+ difference);
            Console.WriteLine("MUL = " + mult);
            Console.WriteLine("DIV = " + div);
        }
    }
}
