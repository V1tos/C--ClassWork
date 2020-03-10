using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8___Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Disk a = new DVD("b",23);
            Console.WriteLine(a.GetName());
        
        }
    }
}
