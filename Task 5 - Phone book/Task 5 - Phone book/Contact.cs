using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5___Phone_book
{
    class Contact
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Contact(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}\nNumber: {Number}");
        }
    }
}
