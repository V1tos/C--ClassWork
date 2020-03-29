using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9___Inheritance__Task_
{
    abstract class Mammal : Animal
    {
        string typeName;

        public Mammal() : base()
        {
            typeName = "Mammal";
        }

        public void ClassSpecific()
        {
            Console.WriteLine($"{typeName} has skin covered with wool and mammary glands");
        }
    }
}
