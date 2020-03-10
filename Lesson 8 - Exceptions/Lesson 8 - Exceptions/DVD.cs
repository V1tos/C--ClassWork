using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8___Exceptions
{
    class DVD : Disk, IRemoveableDisk
    {
        bool hasDisk;

        public DVD()
        {
            this.name = "DVD";
        }

        public DVD(string memory, int memSize)
        {
            this.name = "DVD";
            this.memory = memory;
            this.memSize = memSize;
        }

        public bool HasDisk
        {
            get
            {
                return hasDisk;
            }
        }

        public void Insert()
        {
            hasDisk = true;
        }

        public void Reject()
        {
            hasDisk = false;
        }
    }
}
