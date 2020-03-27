using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Storage
{
    class USB : Storage
    {
        public USB()
        {
            folderList = new List<Folder>();
            fileList = new List<File>();
            Name = "USB";
            Model = "3.0";
            Speed = 300;
            Memory = 16000;
        }
    }
}
