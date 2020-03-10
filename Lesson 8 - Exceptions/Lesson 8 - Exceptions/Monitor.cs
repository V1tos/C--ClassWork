using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8___Exceptions
{
    class Monitor : IPrintInformation
    {
        string name;

        public Monitor()
        {

        }

        public Monitor(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
