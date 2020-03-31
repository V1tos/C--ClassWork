using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Races
{
    class HeavyCar : Car
    {
        public HeavyCar()
        {
            Type = "Heavy car";
            Acceleration = 4;
            MaxSpeed = 40;
            Weight = 3000;
            Passengers = 8;
        }
    }
}
