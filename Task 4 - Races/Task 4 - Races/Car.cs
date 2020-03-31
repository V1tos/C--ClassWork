using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Races
{
    abstract class Car
    {
        public string Type { get; protected set; }
        public int CurrentSpeed { get; protected set; }
        public int Acceleration { get; protected set; }
        public int MaxSpeed { get; protected set; }
        public int Weight { get; protected set; }
        public int Passengers { get; protected set; }


        public delegate void Changing();
        private Changing changeMove;

        public void RegisterToChange(Changing changeMove)
        {
            this.changeMove = changeMove;
        }

        public void Move()
        {
            if (CurrentSpeed < MaxSpeed)
                CurrentSpeed += Acceleration;
            else
                CurrentSpeed = MaxSpeed;           
        }

        public void Change()
        {
            changeMove();
        }

        public void Stop()
        {
            CurrentSpeed = 0;
        }

        public void Break()
        {
            CurrentSpeed -= 20;
        }

        public void Accel()
        {
            if (CurrentSpeed<MaxSpeed)
            {
                CurrentSpeed += 20;
            }           
        }

        public void ShowCar()
        {
            Console.Write($"{Type}, current speed: {CurrentSpeed} m/s");
        }

    }
}
