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
        public string Name { get; private set; }
        Department[] departments;
        public int AvgSalary { get; private set; }
        public int TotalSalary { get; private set; }

        public Factory(string name, int departmentCount, int productCount)
        {
            Name = name;
            departments = new Department[departmentCount];
            products = new Product[productCount];
        }

        public void FillDepartments()
        {
            for (int i = 0; i < departments.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Department N{i+1}");
                Console.Write("Enter department's name: ");
                string name = Console.ReadLine();
                Console.Write("Enter employee's count: ");
                int employeeCount = int.Parse(Console.ReadLine());
                departments[i] = new Department(name, employeeCount);
                departments[i].AddEmployees();
                TotalSalary += departments[i].TotalSalary;
            }
            AvgSalary = TotalSalary / departments.Length;
        }

        public void AddDepartment(Department[] departments)
        {
            this.departments = departments;
            for (int i = 0; i < this.departments.Length; i++)
            {
                TotalSalary += departments[i].TotalSalary;
            }
            AvgSalary = TotalSalary / departments.Length;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Factory name: {Name}\nTotal salary: {TotalSalary}\nAverage salary: {AvgSalary}");
            for (int i = 0; i < departments.Length; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Department N{i + 1}");
                Console.WriteLine("------------------------");
                departments[i].ShowInfo();
            }
        }
     
        partial void SetAvgSalary(double salary);
        partial void SetTotalSalary(int salary);
        partial void SetGDP();
        partial void SetEmpCount();
    }
}
