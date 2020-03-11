using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Tansk_s_battle
{
    class Basement : IPart
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Type { get; private set; }

        public Basement() {}
        public Basement(int width, int height, string type)
        {
            Width = width;
            Height = height;
            Type = type;
        }

        public void ShowBasement()
        {
            Console.WriteLine($"Basement's width = {Width} cm\nBasement's height = {Height} cm\nBasement's type = {Type}");
        }

        public void Exploit()
        {
            Console.WriteLine("Basment is exploiting");
        }
    }
}
