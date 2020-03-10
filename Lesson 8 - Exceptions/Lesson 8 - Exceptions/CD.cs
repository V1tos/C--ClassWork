using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8___Exceptions
{
    class CD : Disk, IRemoveableDisk
    {
        bool hasDisk;

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
