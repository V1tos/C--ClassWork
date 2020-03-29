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

        public void FillProducts()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Product N{i + 1}");
                Console.Write("Enter product's name: ");
                string name = Console.ReadLine();
                Console.Write("Enter product's count: ");
                int size = int.Parse(Console.ReadLine());
                Console.Write("Enter product's price: ");
                double price = double.Parse(Console.ReadLine());
                products[i] = new Product(name, size, price);
            }
        }

        public void SetAvg(int salary)
        {
            SetAvgSalary(salary);
        }

        public void SetTotal(int salary)
        {
            SetTotalSalary(salary);
        }

        partial void SetAvgSalary(double salary)
        {
            if (AvgSalary < salary)
            {
                double persent = salary / AvgSalary;
                TotalSalary = 0;
                for (int i = 0; i < departments.Length; i++)
                {
                    departments[i].SetAvgSalary(departments[i].AvgSalary*persent);
                    TotalSalary += departments[i].TotalSalary;
                }
            }
            else if (AvgSalary > salary)
            {
                double persent = (double)AvgSalary / salary;
                TotalSalary = 0;
                for (int i = 0; i < departments.Length; i++)
                {
                    departments[i].SetAvgSalary(departments[i].AvgSalary / persent);
                    TotalSalary += departments[i].TotalSalary;
                }
            }
            AvgSalary = (int)salary;
        }
        partial void SetTotalSalary(int salary)
        {
            int difference = salary / departments.Length;
            TotalSalary = 0;
            for (int i = 0; i < departments.Length; i++)
            {
                departments[i].SetTotalSalary(difference);
                TotalSalary += departments[i].TotalSalary;
            }
            AvgSalary = TotalSalary / departments.Length;
        }
        partial void SetGDP() { }
        partial void SetEmpCount() { }

    }
}
