using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Tansk_s_battle
{
    class Roof : IPart
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Type { get; private set; }

        public Roof() { }
        public Roof(int width, int height, string type)
        {
            Width = width;
            Height = height;
            Type = type;
        }

        public void ShowRoof()
        {
            Console.WriteLine($"Roof's width = {Width} cm\nRoof's height = {Height} cm\nRoof's type = {Type}");
        }

        public void Exploit()
        {
            Console.WriteLine("Roof is exploiting");
        }
    }
}
