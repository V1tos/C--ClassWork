using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___House
{
    class Worker : IWorker
    {
        public string Name { get; private set; }
        public int Level { get; set; }

        public Worker() { }
        public Worker(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public void Work(House house, params IPart[] part)
        {
            house.SetWork(part);
        }
    }
}
