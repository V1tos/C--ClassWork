using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9___Inheritance__Task_
{
    class Bear : Animal
    {
        public Bear() : base()
        {
            name = "Bear";
            liveEnvironment = "Forest";
            eatType = "forest's food and animals";
        }

        public void ShowInfo()
        {
            Console.WriteLine("Hello");
        }
    }
}
