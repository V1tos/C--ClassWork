using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___House
{
    class Door : IPart
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Type { get; private set; }

        public Door() { }
        public Door(int width, int height, string type)
        {
            Width = width;
            Height = height;
            Type = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Door's width = {Width} cm\nDoor's height = {Height} cm\nDoor's type = {Type}");
        }

        public void Exploit()
        {
            Console.WriteLine("Door is exploiting");
        }
    }
}
