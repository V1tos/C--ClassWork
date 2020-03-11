using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Tansk_s_battle
{
    class Wall : IPart
    {

        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Type { get; private set; }

        public Wall() { }
        public Wall(int width, int height, string type)
        {
            Width = width;
            Height = height;
            Type = type;
        }

        public void ShowWall()
        {
            Console.WriteLine($"Wall's width = {Width} cm\nWall's height = {Height} cm\nWall's type = {Type}");
        }

        public void Exploit()
        {
            Console.WriteLine("Wall is exploiting");
        }

    }
}
