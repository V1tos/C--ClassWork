using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7___HTML_files
{
    class Program
    {
        static void Main(string[] args)
        {

                   
            bool exit = false;
            while (!exit)
            {
                string path = @"D:\ШАГ\Програмування\C# HomeTask\Task 7 - HTML files\";
                string[] arrFiles = Directory.GetFiles(path, "*.html");

                Console.Clear();
                int counter = 0;

                foreach (string item in arrFiles)
                {
                    Console.WriteLine($"{++counter}) {item}");
                }
                Console.Write("1 - Delete file\n2 - Rename file\n3 - Edit file\n0 - Exit\nYour choice: ");
                int choice = int.Parse(Console.ReadLine());
                int index = 0;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter index for delete: ");
                        index = int.Parse(Console.ReadLine());
                        File.Delete(arrFiles[--index]);
                        break;
                    case 2:
                        Console.Write("Enter index for rename: ");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("Enter new name: ");
                        string newName = Console.ReadLine();
                        File.Move(arrFiles[--index], path + newName + ".html");
                        break;
                    case 3:
                        Console.Write("Enter index for edit: ");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("Enter new text: ");
                        string text = Console.ReadLine();
                        using (StreamWriter sw = File.CreateText(arrFiles[--index]))
                        {
                            sw.WriteLine(text);
                        }
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
