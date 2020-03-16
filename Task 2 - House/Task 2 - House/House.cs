using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task_2___House
{
    enum Works
    {
        BUILD_BASEMENT,
        BUILD_WALLS,
        PUT_WINDOWS,
        PUT_DOORS,
        MAKE_ROOF
    }
    
    class House
    {
        Basement basement;
        Wall[] walls;
        Door[] doors;
        Window[] windows;
        Roof roof;

        public Works Stage { get; private set; } = 0;

        public House() { 
        }
        public House(Basement basement, Wall[] walls, Door[] doors, Window[] windows, Roof roof)
        {
            this.basement = basement;
            this.walls = walls;
            this.doors = doors;
            this.windows = windows;
            this.roof = roof;
            
        }

        public void SetWork(params IPart[] part)
        {
            switch (Stage)
            {
                case Works.BUILD_BASEMENT:
                    if (CheckObjectParams(part))
                        SetBasement((Basement)part[0]);
                    break;
                case Works.BUILD_WALLS:
                    if (CheckArrayParams(part))
                        SetWalls((Wall[])part);
                    break;
                case Works.PUT_WINDOWS:
                    if (CheckArrayParams(part))
                        SetWindows((Window[])part);
                    break;
                case Works.PUT_DOORS:
                    if (CheckArrayParams(part))
                        SetDoors((Door[])part);
                    break;
                case Works.MAKE_ROOF:
                    if (CheckObjectParams(part))
                        SetRoof((Roof)part[0]);
                    break;
                default:
                    break;
            }
        }

        public bool CheckArrayParams(params IPart[] part)
        {
            return part.Length > 1;
        }

        public bool CheckObjectParams(params IPart[] part)
        {
            return part.Length == 1;
        }

        private void SetBasement(Basement basement)
        {
            this.basement = basement;
            Stage++;
        }

        private void SetWalls(Wall[] walls)
        {
            this.walls = walls;
            Stage++;
        }

        private void SetWindows(Window[] windows)
        {
            this.windows = windows;
            Stage++;
        }

        private void SetDoors(Door[] doors)
        {
            this.doors = doors;
            Stage++;
        }

        private void SetRoof(Roof roof)
        {
            this.roof = roof;
            Stage++;
        }

        public void ShowStage()
        {
            Console.Clear();
            for (int i = 0; i < (int)Stage; i++)
            {
                ShowResult(i);
                Console.WriteLine();
            }
        }

        public void ShowResult(int stage)
        {
            switch (stage)
            {
                case (int)Works.BUILD_BASEMENT:
                    Console.WriteLine("BASEMENT: ");
                    ShowBasement();
                    break;
                case (int)Works.BUILD_WALLS:
                    Console.WriteLine("WALLS: ");
                    ShowWalls();
                    break;
                case (int)Works.PUT_WINDOWS:
                    Console.WriteLine("WINDOWS: ");
                    ShowWindows();
                    break;
                case (int)Works.PUT_DOORS:
                    Console.WriteLine("DOORS: ");
                    ShowDoors();
                    break;
                case (int)Works.MAKE_ROOF:
                    Console.WriteLine("ROOF: ");
                    ShowRoof();
                    break;
                default:
                    break;
            }
        }

        public void ShowBasement()
        {
            basement.ShowInfo();
        }

        public void ShowWalls()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                Console.WriteLine($"Wall N{i + 1}:");
                walls[i].ShowInfo();
            }
        }

        public void ShowWindows()
        {
            for (int i = 0; i < windows.Length; i++)
            {
                Console.WriteLine($"Window N{i + 1}:");
                windows[i].ShowInfo();
            }
        }

        public void ShowDoors()
        {
            for (int i = 0; i < doors.Length; i++)
            {
                Console.WriteLine($"Door N{i + 1}:");
                doors[i].ShowInfo();
            }
        }

        public void ShowRoof()
        {
            roof.ShowInfo();
        }
      
    }
}
