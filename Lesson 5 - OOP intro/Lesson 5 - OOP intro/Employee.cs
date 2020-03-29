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
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public double Salary { get; set; }
      


        public Employee()
        {
        }
        public Employee(string name,string surname,int age, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }


        public void ShowEmployee()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nSalary: {(int)Salary} UAH");
        }

    }
}
