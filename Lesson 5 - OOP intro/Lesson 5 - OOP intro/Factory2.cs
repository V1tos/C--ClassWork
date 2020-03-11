using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{
    partial class Factory
    {

        Product[] products;

        public void CreateProduct(int size)
        {
            products = new Product[size];
        }

        partial void SetAvgSalary()
        {
            for (int i = 0; i < departments.Length; i++)
            {
                string s = departments[i].Name;
            }
        }
        partial void SetTotalSalary() { }
        partial void SetGDP() { }
        partial void SetEmpCount() { }

    }
}
