using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___House
{
    class Team
    {
        Worker[] workers;
        TeamLeader teamLeader;

        public Team()
        {
            workers = new Worker[5];
            teamLeader = new TeamLeader();
        }

        public void BuildBasement(House house)
        {
            Console.Clear();
            if (house.Stage == Works.BUILD_BASEMENT)
            {
                Console.Write($"Enter basement's width: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write($"Enter basement's height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write($"Enter basement's type: ");
                string type = Console.ReadLine();
                Basement basement = new Basement(width, height, type);

                workers[(int)Works.BUILD_BASEMENT] = new Worker();
                workers[(int)Works.BUILD_BASEMENT].Work(house, basement);
            }       
        }

        public void BuildWalls(House house)
        {
            Console.Clear();
            if (house.Stage == Works.BUILD_WALLS)
            {
                Console.Write("Enter wall's count: ");
                int wallCount = int.Parse(Console.ReadLine());

                Wall[] walls = new Wall[wallCount];

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
                workers[(int)Works.BUILD_WALLS] = new Worker();
                workers[(int)Works.BUILD_WALLS].Work(house, walls);
            }
            else
            {
                Console.WriteLine($"It's wrong work!\nNow house's work's stage: {house.Stage}");
            }
        }

        public void PutWindows(House house)
        {
            Console.Clear();
            if (house.Stage == Works.PUT_WINDOWS)
            {
                Console.Write("Enter windows's count: ");
                int windowCount = int.Parse(Console.ReadLine());

                Window[] windows = new Window[windowCount];

                for (int i = 0; i < windows.Length; i++)
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

                workers[(int)Works.PUT_WINDOWS] = new Worker();
                workers[(int)Works.PUT_WINDOWS].Work(house, windows);
            }
            else
            {
                Console.WriteLine($"It's wrong work!\nNow house's work's stage: {house.Stage}");
            }
        }

        public void PutDoors(House house)
        {
            Console.Clear();
            if (house.Stage == Works.PUT_DOORS)
            {
                Console.Write("Enter windows's count: ");
                int doorCount = int.Parse(Console.ReadLine());

                Door[] doors = new Door[doorCount];

                for (int i = 0; i < doors.Length; i++)
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

                workers[(int)Works.PUT_DOORS] = new Worker();
                workers[(int)Works.PUT_DOORS].Work(house, doors);
            }
            else
            {
                Console.WriteLine($"It's wrong work!\nNow house's work's stage: {house.Stage}");
            }
        }

        public void MakeRoof(House house)
        {
            Console.Clear();
            if (house.Stage == Works.MAKE_ROOF)
            {
                Console.Write($"Enter roof's width: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write($"Enter roof's height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write($"Enter roof's type: ");
                string type = Console.ReadLine();
                Roof roof = new Roof(width, height, type);

                workers[(int)Works.MAKE_ROOF] = new Worker();
                workers[(int)Works.MAKE_ROOF].Work(house, roof);
            }
            else
            {
                Console.WriteLine($"It's wrong work!\nNow house's work's stage: {house.Stage}");
            }
        }

        public void ShowResult(House house)
        {
            teamLeader.Work(house);
        }
    }
}
