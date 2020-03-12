using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9___Inheritance__Task_
{
    abstract class Animal : Being
    {
        protected string name;
        protected string liveEnvironment;
        protected string eatType;
        protected string breatheEnvironment;

        public Animal()
        {
            type = "Animal";
        }

        public override void Live()
        {
            Console.WriteLine($"{name} lives in {liveEnvironment}");
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} eats {eatType}");
        }

        public override void Breathe()
        {
            Console.WriteLine($"{name} breathes in {breatheEnvironment}");
        }

    }
}
