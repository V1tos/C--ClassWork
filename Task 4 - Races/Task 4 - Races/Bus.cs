using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Races
{
    class Bus : Car
    {
        public Bus()
        {
            Type = "Bus";
            Acceleration = 3;
            MaxSpeed = 30;
            Weight = 5000;
            Passengers = 25;
        }
    }
}
