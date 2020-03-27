using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_3___Storage
{

//    Разработать приложение «Резервная копия»
//Цель: произвести расчет необходимого количества внешних носителей информации при переносе за один раз
//важной информации(565 Гб, файлы по 780 Мб) с рабочего
//компьютера на домашний компьютер и затрачиваемое
//на данный процесс время.Вы имеете в распоряжении
//следующие типы носителей информации:
//■ Flash-память,
//■ DVD-диск,
//■ съемный HDD.
//Каждый носитель информации является объектом соответствующего класса:
// Лабораторная работа №5 Лабораторная работа №<Номер дз>
//■ Flash-память — класс «Flash»;
//■ класс DVD-диск — класс «DVD»;
//■ класс съемный HDD — класс «HDD».
//Все три класса являются производными от абстрактного
//класса «Носитель информации» — класс «Storage».
//Базовый класс(«Storage») содержит следующие закрытые
//поля:
//■ наименование носителя;
//■ модель.
//Класс обладает всеми необходимыми свойствами для
//доступа к полям, а также абстрактными методами:
//■ получение объема памяти;
//■ копирование данных(файлов/папок) на устройство,
//■ получение информации о свободном объеме памяти
//на устройстве;
//■ получение общей/полной информации об устройстве.
//Кроме того, каждый из производных классов дополняется
//следующими полями:
//■ класс Flash-память: скорость USB 3.0, объем памяти;
//■ класс DVD-диск: скорость чтения / записи, тип
//(односторонний (4.7 Гб) /двусторонний(9 Гб));
//■ класс съемный HDD: скорость USB 2.0, количество
//разделов, объем разделов.
//Работа с объектами соответствующих классов производится через ссылки на базовый класс(«Storage»), которые
//хранятся в массиве.
//Лабораторная работа №5 Лабораторная работа №<Номер дз>
//Приложение должно предоставлять следующие возможности:
//■ расчет общего количества памяти всех устройств;
//■ копирование информации на устройства;
//■ расчет времени необходимого для копирования;
//■ расчет необходимого количества носителей информации представленных типов для переноса
//информации.
    class Program
    {
        static int storageSpeed;
        static int storageFreeMemory;
        static object cashObject = new object();
        static List<string> way;
        static List<Folder> tempFolders = new List<Folder>();
        static List<Storage> storages = new List<Storage>();

        static void MainMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                ShowStorages();
                Console.Write("o - Open storage\na - Add Storage\n0 - Exit\nYour choice: ");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "o":
                        OpenStorage();
                        break;
                    case "a":
                        AddStorage();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

        }

        static void ShowStorages()
        {
            for (int i = 0; i < storages.Count; i++)
            {
                Console.Write($"{i + 1}) ");
                storages[i].ShowInfo();
            }
        }

        static void OpenStorage()
        {
            Console.Write("Storage N");
            int choice = int.Parse(Console.ReadLine());

            if (choice <= storages.Count && choice != 0)
            {
                way = new List<string>();
                storageFreeMemory = storages[--choice].FreeMemory();
                storageSpeed = storages[choice].Speed;
                OpenFolder(storages[choice]);

            }
            else
            {
                OpenStorage();
            }
        }

        static void OpenFolder(Folder folder)
        {
            Console.Clear();
            folder.RefreshCapacity();
            ShowWay(folder);
            folder.ShowFolder();
            ChoiceMenu(folder);
        }

        static void ShowWay(Folder folder)
        {
            way.Add(folder.Name);
            Console.Write($"Way: ");
            for (int i = 0; i < way.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{way[i]}/");
                }
                else
                {
                    Console.Write($"{way[i]}/");
                }
            }
            Console.WriteLine("\n");
        }

        static void ChoiceMenu(Folder folder)
        {
            Console.WriteLine($"1 - Create file\n2 - Create Folder\nb - Back\nc - Copy\np - Paste\nz - Cut\nd - Delete\no - Open folder");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CreateFile(folder);
                    way.RemoveAt(way.Count - 1);
                    OpenFolder(folder);
                    break;
                case "2":
                    CreateFolder(folder);
                    way.RemoveAt(way.Count - 1);
                    OpenFolder(folder);
                    break;
                case "b":
                    FolderBefore(folder);
                    break;
                case "c":
                    CopyMenu(folder);
                    break;
                case "d":
                    DeleteMenu(folder);
                    break;
                case "z":
                    CutMenu(folder);
                    break;
                case "p":
                    PasteObject(folder);
                    break;
                case "o":
                    FolderTrans(folder);
                    break;
                default:
                    way.RemoveAt(way.Count - 1);
                    OpenFolder(folder);
                    break;
            }
        }

        #region
        static void CreateFile(Folder folder)
        {
            Console.Write("Enter file's name: ");
            string fileName = Console.ReadLine();
            Console.Write("Enter file's extansion: ");
            string fileExtansion = Console.ReadLine();
            Console.Write("Enter file's capacity: ");
            int fileCapacity = int.Parse(Console.ReadLine());

            if (storageFreeMemory >= fileCapacity)
            {
                folder.fileList.Add(new File(fileName, fileCapacity, fileExtansion));
            }
            else
            {
                Console.WriteLine("Storage doesn't have enough memory");
                Thread.Sleep(1500);
            }
        }
        static void CreateFolder(Folder folder)
        {
            Console.Write("Enter folder's name: ");
            string folderName = Console.ReadLine();

            folder.folderList.Add(new Folder(folderName));
        }
        #endregion

        static void FolderBefore(Folder folder)
        {
            if (tempFolders.Count > 0)
            {
                folder = tempFolders[tempFolders.Count - 1];
                tempFolders.RemoveAt(tempFolders.Count - 1);
                way.RemoveAt(way.Count - 1);
                way.RemoveAt(way.Count - 1);
                OpenFolder(folder);
            }
        }

        #region
        static void CopyMenu(Folder folder)
        {
            Console.Write("Enter number: ");
            int index = int.Parse(Console.ReadLine());
            CopyChoice(folder, index);
            way.RemoveAt(way.Count - 1);
            OpenFolder(folder);
        }
        static void CopyChoice(Folder folder, int index)
        {
            List<object> objects = new List<object>();

            foreach (Folder item in folder.folderList)
                objects.Add(item);

            foreach (File item in folder.fileList)
                objects.Add(item);

            for (int i = 0; i < objects.Count; i++)
            {
                if (i == index - 1)
                    CopyObject(objects[i]);
            }
        }
        static void CopyObject(object obj)
        {
            cashObject = obj;
        }
        #endregion

        #region
        static void DeleteMenu(Folder folder)
        {
            Console.Write("Enter number: ");
            int index = int.Parse(Console.ReadLine());
            DeleteChoice(folder, index);
            way.RemoveAt(way.Count - 1);
            OpenFolder(folder);
        }
        static void DeleteChoice(Folder folder, int index)
        {
            if (index <= folder.folderList.Count)
            {
                for (int i = 0; i < folder.folderList.Count; i++)
                {
                    if (i == index - 1)
                        folder.folderList.RemoveAt(i);
                }
            }
            else
            {
                for (int i = 0; i < folder.fileList.Count; i++)
                {
                    if (i == (index - folder.folderList.Count - 1))
                        folder.fileList.RemoveAt(i);
                }
            }
        }
        #endregion

        #region
        static void CutMenu(Folder folder)
        {
            Console.Write("Enter number: ");
            int index = int.Parse(Console.ReadLine());
            CutChoice(folder, index);
            way.RemoveAt(way.Count - 1);
            OpenFolder(folder);
        }
        static void CutChoice(Folder folder, int index)
        {
            CopyChoice(folder, index);
            DeleteChoice(folder, index);
        }
        #endregion

        #region
        static void PasteObject(Folder folder)
        {
            PasteDuration();

            File cashFile = cashObject as File;
            Folder cashFolder = cashObject as Folder;

            if (cashFile is File)
            {
                if (cashFile.Capacity != 0)
                {
                    if (storageFreeMemory >= cashFile.Capacity)
                    {
                        folder.AddFile(cashFile);
                    }
                    else
                    {
                        Console.WriteLine("Storage doesn't have enough memory");
                        Thread.Sleep(1500);
                    }
                }
            }
            else if (cashFolder is Folder)
            {
                if (storageFreeMemory >= cashFolder.Capacity)
                {
                    folder.AddFolder(cashFolder);
                }
                else
                {
                    Console.WriteLine("Storage doesn't have enough memory");
                    Thread.Sleep(1500);
                }
            }
            cashObject = new object();
            way.RemoveAt(way.Count - 1);
            OpenFolder(folder);
        }
        static void PasteDuration()
        {
            File cashFile = cashObject as File;
            Folder cashFolder = cashObject as Folder;

            if (cashFolder is Folder)
            {
                if (cashFolder.Capacity > storageSpeed)
                {
                    PastFolderDuration(cashFolder);
                    Thread.Sleep(1500);
                }
            }
            else if (cashFile is File)
            {
                if (cashFile.Capacity > storageSpeed)
                {
                    PastFileDuration(cashFile);
                    Thread.Sleep(1500);
                }
            }
        }
        static void PastFolderDuration(Folder folder)
        {
            Console.Clear();
            int currentCapacity = 0;
            Console.WriteLine($"Speed = {storageSpeed}Mb/s");
            Console.Write($"{currentCapacity}Mb/{folder.Capacity}Mb");

            while (currentCapacity < folder.Capacity)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine($"Speed = {storageSpeed}Mb/s");
                currentCapacity += storageSpeed;
                if (currentCapacity >= folder.Capacity)
                    Console.Write($"{folder.Capacity}Mb/{folder.Capacity}Mb - Done");
                else
                    Console.Write($"{currentCapacity}Mb/{folder.Capacity}Mb");
            }
        }
        static void PastFileDuration(File file)
        {
            Console.Clear();
            int currentCapacity = 0;
            Console.WriteLine($"Speed = {storageSpeed}Mb/s");
            Console.Write($"{currentCapacity}Mb/{file.Capacity}Mb");

            while (currentCapacity < file.Capacity)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine($"Speed = {storageSpeed}Mb/s");
                currentCapacity += storageSpeed;
                if (currentCapacity >= file.Capacity)
                    Console.Write($"{file.Capacity}Mb/{file.Capacity}Mb - Done");
                else
                    Console.Write($"{currentCapacity}Mb/{file.Capacity}Mb");
            }
        }
        #endregion

        static void FolderTrans(Folder folder)
        {
            if (folder.folderList.Count > 0)
            {
                Console.Write("Folder N");
                int choice = int.Parse(Console.ReadLine());

                if (choice <= folder.folderList.Count && choice != 0)
                {
                    tempFolders.Add(folder);
                    OpenFolder(folder.folderList[--choice]);
                }
                else
                {
                    way.RemoveAt(way.Count - 1);
                    OpenFolder(folder);
                }
            }
        }

        static void AddStorage()
        {
            Console.Clear();
            Console.Write("Enter your device:\n1 - USB\n2 - DVD\n3 - HDD\nYour choice: ");
            int storageChoice = int.Parse(Console.ReadLine());

            switch (storageChoice)
            {
                case 1:
                    storages.Add(new USB());
                    break;
                case 2:
                    storages.Add(new DVD());
                    break;
                case 3:
                    storages.Add(new HDD());
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {

            #region
            Folder folder = new Folder("0 folder");
            Folder folder1 = new Folder("1 folder");
            Folder folder2 = new Folder("2 folder");

            Folder a = new Folder();
            Folder b = new Folder();

            folder.AddFile(new File("Job", 10, "exe"));
            folder1.AddFile(new File("Work", 35, "exe"));
            folder2.AddFile(new File("Drink", 50, "exe"));
            folder2.AddFile(new File("Jack", 40, "exe"));
            folder2.AddFile(new File("Frank", 120, "exe"));

            b.AddFile(new File("Bronson", 70, "exe"));
            a.AddFolder(b);

            folder2.AddFolder(a);

            a.Name = "3 folder";
            b.AddFile(new File("Www", 30, "exe"));
            b.AddFile(new File("W2", 80, "exe"));

            folder1.AddFile(new File("Vitya", 55, "txt"));
            folder2.AddFile(new File("Vitya", 55, "txt"));
            a.AddFile(new File("Bronson", 70, "exe"));

            folder1.AddFolder(folder2);
            folder.AddFolder(folder1);
            #endregion

            storages.Add(new HDD());
            storages[0].AddFolder(folder);

            storages.Add(new USB());
            storages[1].AddFolder(folder1);
            storages.Add(new DVD());
            storages[2].AddFolder(folder2);
            MainMenu();        
        }
    }
}
