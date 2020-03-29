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
        public string Name { get; private set; }
        Employee[] employees;
        public int AvgSalary { get; private set; }
        public int TotalSalary { get; private set; }

        public Department(string name,int employeeCount)
        {
            Name = name;
            employees = new Employee[employeeCount];
        }

        public void AddEmployees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee N{i+1}");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter surname: ");
                string surname = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter salary: ");
                double salary = double.Parse(Console.ReadLine());
                employees[i] = new Employee(name, surname, age, salary);
                TotalSalary += (int)salary;
            }
            AvgSalary = TotalSalary / employees.Length;
        }

        public void AddEmp(Employee[] employees)
        {
            this.employees = employees;
            for (int i = 0; i < this.employees.Length; i++)
            {
                TotalSalary += (int)employees[i].Salary;
            }
            AvgSalary = TotalSalary / employees.Length;
        }

        public void SetAvgSalary(double salary)
        {           
            if (AvgSalary < salary)
            {
                double persent = salary / AvgSalary;
                TotalSalary = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    employees[i].Salary = employees[i].Salary * persent;
                    TotalSalary += (int)employees[i].Salary;
                }              
            }
            else if (AvgSalary > salary)
            {
                double persent = AvgSalary / salary;
                TotalSalary = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    employees[i].Salary = employees[i].Salary / persent;
                    TotalSalary += (int)employees[i].Salary;
                }
            }
            AvgSalary = (int)salary;
        }

        public void SetTotalSalary(int salary)
        {
            if (TotalSalary < salary)
            {
                int difference = (salary - TotalSalary)/employees.Length;
                TotalSalary = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    employees[i].Salary = employees[i].Salary + difference;
                    TotalSalary += (int)employees[i].Salary;
                }
            }
            else if(TotalSalary > salary)
            {
                int difference = (TotalSalary - salary) / employees.Length;
                TotalSalary = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    employees[i].Salary = employees[i].Salary - difference;
                    TotalSalary += (int)employees[i].Salary;
                }
            }
            AvgSalary = TotalSalary / employees.Length;
        }

        public void ShowSalary()
        {
            Console.WriteLine($"Total salary = {TotalSalary}\nAverage salary = {AvgSalary}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Department's name: {Name}\nTotal salary: {TotalSalary}\nAverage salary: {AvgSalary}");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("************************");
                employees[i].ShowEmployee();
                Console.WriteLine("************************");
            }
        }
        
    }
}
