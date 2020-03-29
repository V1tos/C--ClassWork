using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{
    //Class Product містить авто-властивість string Name, авто-властивість int Size, авто-властивість double Price, метод string ReturnString()
    class Product
    {
        public string Name { get; private set; }
        public int Size { get; private set; }
        public double Price { get; set; }

        public Product(string name, int size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }



    }
}
