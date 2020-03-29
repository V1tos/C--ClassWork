using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9___Inheritance__Task_
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal a = new Bear();
            a.Live();
            a.Eat();
            a.Breathe();
            a.ClassSpecific();
            
            


            
           
        }
    }
}
