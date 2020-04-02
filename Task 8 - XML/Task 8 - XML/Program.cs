using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Task_8___XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Розробити програму по роботі з XML - документом "Список контактів"
            // Програма через меню повинна забезпечити:
            //a) Додавання контакту
            //б) Редагування контакту
            //г) Видалення
            //д) Показати всі контакти
            //ж) Пошук по імені

            OperationXML work = new OperationXML();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(" [1] Add\n [2] Edit\n [3] Delete\n [4] Show\n [5] Sherch\n [0] Exit");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        work.Add_element();
                        Console.WriteLine("\n Enter any key to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        work.Edit_file();
                        Console.WriteLine("\n Enter any key to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        work.Delete_element();
                        Console.WriteLine("\n Enter any key to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        work.Show_file();
                        Console.WriteLine("\n Enter any key to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        work.Sherch_by_name();
                        Console.WriteLine("\n Enter any key to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
