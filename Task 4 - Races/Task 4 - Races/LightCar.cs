using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Races
{
    class LightCar : Car
    {
        public LightCar()
        {
            Type = "Light car";
            Acceleration = 7;
            MaxSpeed = 70;
            Weight = 500;
            Passengers = 4;
        }
    }
}
