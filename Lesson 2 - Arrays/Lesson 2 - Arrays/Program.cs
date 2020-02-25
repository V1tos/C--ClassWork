using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int START_BALANCE=1000;
            double totalBalance = START_BALANCE;

            Console.WriteLine("Enter persent per year:");

            int p = int.Parse(Console.ReadLine());

            double monthPersent = p*START_BALANCE / 100/12;

            int month = 0;
           
            for (int i = 0; i < totalBalance; i++)
            {
                totalBalance += monthPersent;
                if (totalBalance>=1100)
                {
                    month = i+1;
                    break;
           
                }
                
            }

            Console.WriteLine("Total balance: {0}\nMonth N: {1}",totalBalance, month);

        }


      


    }
}
