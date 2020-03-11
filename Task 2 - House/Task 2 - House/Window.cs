using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Tansk_s_battle
{
    class Window : IPart
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Type { get; private set; }

        public Window() { }
        public Window(int width, int height, string type)
        {
            Width = width;
            Height = height;
            Type = type;
        }

        public void ShowDoor()
        {
            Console.WriteLine($"Window's width = {Width} cm\nWindow's height = {Height} cm\nWindow's type = {Type}");
        }

        public void Exploit()
        {
            Console.WriteLine("Window is exploiting");
        }
    }
}
