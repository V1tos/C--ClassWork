using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___House
{
    interface IWorker
    {
        void Work(House house, params IPart[] part);
    }
}
