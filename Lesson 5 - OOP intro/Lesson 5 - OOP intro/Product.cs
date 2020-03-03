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
        string name;
        int size;
        double price;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
}
