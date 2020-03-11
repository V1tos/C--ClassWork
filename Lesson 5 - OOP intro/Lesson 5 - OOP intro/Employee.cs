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

        public Employee()
        {
        }
        public Employee(string name,string surname,int age, decimal salary)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
        }
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

        public void CreateEmployee()
        {
            if (EmptyParams())
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter surname: ");
                surname = Console.ReadLine();
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter salary: ");
                salary = decimal.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Employee has been created");
            }
                
        }

        public bool EmptyParams()
        {
            return (name == null && surname == null && age == 0 && salary == 0);
        }

        public void ShowEmployee()
        {
            Console.WriteLine($"Name: {name}\nSurname: {surname}\nAge: {age}\nSalary: {salary}");
        }

    }
}
