using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Tansk_s_battle
{
    class TeamLeader
    {
        public string Name { get; private set; }
        public int Level { get; private set; }

        public TeamLeader() { }
        public TeamLeader(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public void Work(string workType)
        {
            Console.WriteLine($"Team leader {Name} is making {workType}");
        }
    }
}
