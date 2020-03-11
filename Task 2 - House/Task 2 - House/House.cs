using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Tansk_s_battle
{
    class House
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        private Basement basement;
        private Wall[] walls;
        private Door[] doors;
        private Window[] windows;
        private Roof roof;

        public House() { }
        public House(Basement basement, Wall[] walls,Door[] doors, Window[] windows,Roof roof)
        {
            this.basement = basement;
            this.walls = walls;
            this.doors = doors;
            this.windows = windows;
            this.roof = roof;
        }

        public void Build()
        {
            BuildBasement();
            BuildWall();
            PutDoor();
            PutWindow();
            MakeRoof();
        }

        public void BuildBasement()
        {      
            Console.Write($"Enter basement's width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write($"Enter basement's height: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write($"Enter basement's type: ");
            string type = Console.ReadLine();
            basement = new Basement(width, height, type);
        }

        public void BuildWall()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Wall N{i + 1}:");
                Console.Write($"Enter wall's width: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write($"Enter wall's height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write($"Enter wall's type: ");
                string type = Console.ReadLine();
                walls[i] = new Wall(width, height, type);
            }
        }

        public void PutDoor()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Door N{i + 1}:");
                Console.Write($"Enter door's width: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write($"Enter door's height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write($"Enter door's type: ");
                string type = Console.ReadLine();
                doors[i] = new Door(width, height, type);
            }
        }

        public void PutWindow()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Window N{i + 1}:");
                Console.Write($"Enter window's width: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write($"Enter window's height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write($"Enter window's type: ");
                string type = Console.ReadLine();
                windows[i] = new Window(width, height, type);
            }
        }

        public void MakeRoof()
        {
            Console.Write($"Enter roof's width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write($"Enter roof's height: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write($"Enter roof's type: ");
            string type = Console.ReadLine();
            roof = new Roof(width, height, type);
        }

        //public bool isReady()
        //{
        //    return()
        //}

    }
}
