using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Races
{
    class SportCar : Car
    {

        public SportCar()
        {
            Type = "Sport car";
            Acceleration = 10;
            MaxSpeed = 100;
            Weight = 300;
            Passengers = 2;
        }
    }
}
