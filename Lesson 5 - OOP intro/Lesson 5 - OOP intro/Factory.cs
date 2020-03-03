using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{
    //Class Factory, містить авто-властивість string Name, масив Departments[], масив Products[], метод string ReturnString();
    class Factory
    {
        string name;
        Department[] departments;
        Product[] products;
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

        public void CreateDepartment(int size)
        {
            departments = new Department[size];
        }

        public void CreateProduct(int size)
        {
            products = new Product[size];
        }
    }
}
