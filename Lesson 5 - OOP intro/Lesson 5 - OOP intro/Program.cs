using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            a.CreateEmployee();
            a.CreateEmployee();

            a.ShowEmployee();
        }
    }
}
