using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Storage
{
    class DVD : Storage
    {
        public DVD()
        {
            folderList = new List<Folder>();
            fileList = new List<File>();
            Name = "DVD";
            Model = "RW";
            Speed = 150;
            Memory = 9000;
        }
    }
}
