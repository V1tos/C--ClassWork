using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Storage
{
    class Folder
    {
        public string Name { get; set; } = "New folder";
        public List<File> fileList;
        public List<Folder> folderList;
        public int Capacity { get; private set; } = 0;
        

        public Folder()
        {
            fileList = new List<File>();
            folderList = new List<Folder>();
        }

        public Folder(string name)
        {
            Name = name;
            fileList = new List<File>();
            folderList = new List<Folder>();
        }

        public void AddFile(File file)
        {
            fileList.Add(file);
            RefreshCapacity();
        }

        public void AddFolder(Folder folder)
        {         
            folderList.Add(folder);
            RefreshCapacity();
        }

        public void RefreshCapacity()
        {
            Capacity = RootCapacity();
            foreach (Folder item in folderList)
            {
                item.RefreshCapacity();
            }
        }
      
        private int RootCapacity()
        {
            int sum = FilesCapacity();

            foreach (Folder item in folderList)
            {
                sum += item.RootCapacity();
            }
            return sum;
        }

        private int FilesCapacity()
        {
            int sum = 0;
            foreach (File item in fileList)
            {
                sum += item.Capacity;
            }
            return sum;
        }

        public void ShowFolder()
        {
            Console.WriteLine($"<<{ Name} - {Capacity} Mb - Current folder>>");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"N)  |Name|  |Capcity|  |Type|");
            Console.WriteLine("------------------------------");   

            int iterator = 0;

            foreach  (Folder item in folderList)
            {
                Console.Write($"{++iterator}) ");
                item.ShowInfo();
            }

            foreach (File item in fileList)
            {
                Console.Write($"{++iterator}) ");
                item.ShowInfo();
            }

            Console.WriteLine("------------------------------");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name} - {Capacity} Mb - Folder");
        }
    }
}
