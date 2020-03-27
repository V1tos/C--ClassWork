using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Storage
{
    class File
    {
        public string Name { get; set; } = "New file";
        public int Capacity { get; private set; } = 0;
        public string Extansion { get; private set; } = "doc";

        public File() { }
        public File(string name, int capacity, string extansion)
        {
            Name = name;
            Capacity = capacity;
            Extansion = extansion;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}.{Extansion} - {Capacity} Mb - File");
        }
    }
}
