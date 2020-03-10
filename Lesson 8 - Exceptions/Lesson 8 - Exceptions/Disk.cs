using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8___Exceptions
{
   abstract class Disk : IDisk
    {
        protected string name;
        protected string memory;
        protected int memSize;

        public string Memory
        {
            get
            {
                return memory;
            }
            set
            {
                memory = value;
            }
        }
        public int MemSize
        {
            get
            {
                return memSize;
            }
            set
            {
                memSize = value;
            }
        }

        public Disk()
        {
        }

        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }

        public string GetName()
        {
            return name;
        }
        
            
        
        public string Read()
        {
            return memory;
        }

        public void Write(string text)
        {
            memory +=("\n"+ text);
        }
    }
}
