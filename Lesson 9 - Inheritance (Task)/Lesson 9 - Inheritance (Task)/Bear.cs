using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9___Inheritance__Task_
{
    class Bear : Mammal , IRunning
    {
        public Bear() : base()
        {
            name = "Bear";
            liveEnvironment = "Forest";
            eatType = "forest's food and animals";
            breatheEnvironment = "around environment";
        }

        public void Run()
        {
            Console.WriteLine($"{name} runs with average speed 40 km/h");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Hello");
        }
    }
}
