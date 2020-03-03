using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{
    //Class Employee містить авто-властивість string Name, авто-властивість string Surname, авто-властивість int Age, авто-властивість decimal Salary, 
    //    метод string ReturnString()
    class Employee
    {
        string name;
        string surname;
        int age;
        decimal salary;
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
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

    }
}
