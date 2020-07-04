using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13___Data_grid_view
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class Employees : IEnumerable
    {
        List<Employee> employees = new List<Employee>();

        public Employees()
        {
            employees.AddRange(new[]
            {
                new Employee{Id = 1 , Name = "Jack", Salary = 8000},
                new Employee{Id = 2 , Name = "Bill", Salary = 6000},
                new Employee{Id = 3 , Name = "John", Salary = 7000},
            });
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
    }
}
