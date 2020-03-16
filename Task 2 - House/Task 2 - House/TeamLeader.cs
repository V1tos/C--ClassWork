using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___House
{
    class TeamLeader : IWorker
    {
        public void Work(House house, params IPart[] part)
        {
            house.ShowStage();
        }
    }
}
