using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___OOP_intro
{
    //    Описати за допомогою класів структуру підприємства
    //1. Class Factory - модифікувати і перетворити на partial class. 
    //2. Описання полів та оголошеня масиву Департаментів зробити в 1й частині(в першому файлі),
    // оголошення масиву Products[] та оголошення і реалізацію методу string ReturnString() в 2му.
    // 3. Створти 4 partial метода: a)void SetAvgSalary - встановлення для відповідного приватного поля середньої
    // ЗП по підприємству b) void SetTotalSalary - встановлення для відповідного приватного поля сумарної ЗП c)
    //    void SetGDP - встановлення для відповідного приватного поля валового доходу
    // на 1го працівника - сума вартості всіх товарів / на кількість працівників d)
    //    Void SetEmpCount - встановлення для відповідного поля загальної кількості працюючих 
    // 4. Для отримання даних з відповідних приватних полів творити відповідні публічні інтерфейси-методи
    //5.Оголошення часткових методів зробити в 1й частині, а реалізацію виконати в 2частині класу(в іншому файлі) 
    // 6.Зміна структури класу Фабрика не повинна вплинути на описи інших класів 
    //7.Змінити поле “Ім”я “ для департаменту на readonly, 
    // яке повинне ініціалізуватися у параметризованому конструкторі заданим строковим параметром. 8.Класи розмежовуюься окремими файлами.


    //Class Factory, містить авто-властивість string Name, масив Departments[], масив Products[], 
    //    метод string ReturnString(); 2. Class Department містить авто-властивість string Name, 
    //    масив Employees[], метод string ReturnString(); 3. Class Employee містить авто-властивість string Name, 
    //    авто-властивість string Surname, авто-властивість int Age, авто-властивість decimal Salary, 
    //    метод string ReturnString(); 4. Class Product містить авто-властивість string Name, авто-властивість int Size, 
    //    авто-властивість double Price, метод string ReturnString(); 5. Класи розмістити в окремих файлахз відповідними класами


    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Bill","Bronson",40, 1500);
            Employee employee2 = new Employee("Jack", "Foden", 38, 2500);           
            Employee[] employees = { employee1, employee2 };

            Employee employee3 = new Employee("John", "Snow", 30, 5000);
            Employee employee4 = new Employee("Steve", "Leger", 38, 7000);
            Employee[] employees2 = { employee3, employee4 };





            //Factory factory = new Factory("Roshen",3,5);
            //factory.FillDepartments();
            Factory factory = new Factory("Roshen", 2, 2);
            
            Department department = new Department("Laboratory", 2);
            Department department1 = new Department("Audit", 2);
            department.AddEmp(employees);
            department1.AddEmp(employees2);

         
            //department.SetAvgSalary(18000);
            //department.ShowInfo();
            //department.ShowSalary();

            Department[] departments = { department, department1 };
            factory.AddDepartment(departments);
            factory.SetAvg(300000);
            factory.ShowInfo();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("After SET");
            //department.ShowInfo();
            //Console.WriteLine("---------------------");
            //department1.ShowInfo();

            factory.SetTotal(1000000);
            factory.ShowInfo();
        }
    }
}
