 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9___Inheritance__Task_
{
    abstract class Being
    {
        protected string type;

        public virtual void Live() { }
        public virtual void Eat() { }
        public virtual void Breathe() { }
    }
}
