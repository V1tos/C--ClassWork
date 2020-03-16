using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10___Delegates
{
    class Program
    {
        //        Завдання:
        //Написати програму для виконання операцій з одновимірним масивом за
        //допомогою делегатів.Користувачу надається наступне меню для вибору типа
        //операції з масивом:
        //1. обчислення значення
        //2. зміна масиву
        //Якщо користувач вибрав 1-й тип, вивести підменю вибору операції:
        //i.Обчислити кількість негативних елементів
        //ii.Визначити суму всіх елементів
        //iii. * Обрахувати кількість простих чисел
        //2-й тип:
        //i.Змінити всі негативні елементи на 0
        //ii.Відсортувати масив
        //iii. * Перемістити всі парні елементи на початку, відповідно не парні будуть в
        // кінці.

        // Створити вказані вище методи та реалізувати вибір користувачем операції на
        // виконання без використання конструкцій if, switch та?:(тернарного) оператора.
        //Методи першого типу повинні повертати результат обчислення, в той час методи
        // другого типу – void.
        //Реалізувати валідацію вибраного номера операції.

        static MyArray arr;
        
        static void Main(string[] args)
        {
            arr = new MyArray(10);
            arr.Fill();
            Menu(arr);           
        }
        public static void Menu(MyArray array)
        {
            
            int choice = 0;
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.Write("1 - Calculate array\n2 - Change array\n3 - Show array\n0 - Exit\nYour choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CalculateMenu(array);
                        Console.ReadLine();
                        break;
                    case 2:
                        ChangeMenu(array);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        array.Show();
                        Console.ReadLine();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
            
        }

        public static void CalculateMenu(MyArray array)
        {
            Console.Clear();
            int choice = 0;
            Console.Write("1 - Sum of negative elements\n2 - Sum of all elements\nYour choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    array.RegisterToChange(SumNegativeElements);
                    array.Change();
                    break;
                case 2:
                    Console.Clear();
                    array.RegisterToChange(SumAllElements);
                    array.Change();
                    break;
                default:
                    break;
            }
        }

        public static void ChangeMenu(MyArray array)
        {
            Console.Clear();
            int choice = 0;
            Console.Write("1 - Change all elements to 0\n2 - Sort array\nYour choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    array.RegisterToChange(NegativeToNull);
                    array.Change();
                    break;
                case 2:
                    Console.Clear();
                    array.RegisterToChange(SortArray);
                    array.Change();
                    break;
                default:
                    break;
            }
        }



        private static void SumNegativeElements()
        {
            Console.WriteLine($"Sum of negative's elements: {arr.SumNegative()}");     
        }

        private static void SumAllElements()
        {
            Console.WriteLine($"Sum of all elements: {arr.SumAll()}");
        }

        private static void NegativeToNull()
        {
            arr.ChangeToNull();
            Console.WriteLine("Negative elements changed to 0:");
            arr.Show();
        }

        private static void SortArray()
        {
            arr.Sort();
            Console.WriteLine("Sorted Array: ");
            arr.Show();
        }
    }
}
