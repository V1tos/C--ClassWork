using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13___Data_grid_view
{
    public class Car
    {
        public string Brend { get; set; }
        public string Model { get; set; }
        public float Capacity { get; set; }
    }

    public class Garage : IEnumerable
    {
        List<Car> cars = null;
        public Garage()
        {
            cars = new List<Car>()
            {
                new Car{Brend = "Audi", Model = "R8", Capacity = 3.5f},
                new Car{Brend = "Bmw", Model = "X5", Capacity = 4.0f},
                new Car{Brend = "Skoda", Model = "A5", Capacity = 2.0f}
            };
        }
        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }
}
