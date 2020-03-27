using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Storage
{
    class HDD : Storage
    {
        public HDD()
        {
            folderList = new List<Folder>();
            fileList = new List<File>();
            Name = "HDD";
            Model = "2.0";
            Speed = 600;
            Memory = 500000;
        }
    }
}
