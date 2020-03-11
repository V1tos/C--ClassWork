using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{

    //Class Department містить авто-властивість string Name, масив Employees[], метод string ReturnString();
    class Department
    {
        string name;
        Employee[] employees;

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

        public void AddEmployees()
        {
            if (employees.Length>0)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"Employee N{i + 1}");
                    employees[i].CreateEmployee();
                }
            }      
        }
    }
}
