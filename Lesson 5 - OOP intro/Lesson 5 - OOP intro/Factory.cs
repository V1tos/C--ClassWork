using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{
    //Class Factory, містить авто-властивість string Name, масив Departments[], масив Products[], метод string ReturnString();
   partial class Factory
    {
        string name;
        Department[] departments;
        
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

        partial void SetAvgSalary();
        partial void SetTotalSalary();
        partial void SetGDP();
        partial void SetEmpCount();
    }
}
