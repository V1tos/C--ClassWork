using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Races
{
//    Розробити гру "Гонки" з використанням делегатів.Щоб подивитись опис даного завдання натисніть тут.

//В грі використати кілька класів автомобілів(спортивні, легкові, грузові і автобуси). 
//Розробити методи і властивості для кожного з оголошених класів.
//Реалізувати гру у вигляді класу, який за допомогою делегатів управляє автомобілями в процесі гри.
//Рекомендації по виконанню роботи: 
//Розробити віртуальний клас "Car" (Автомобіль). Можна скористатись вже розробленим раніше в уроці 6, тільки допрацювати його.
//В даному класі зібрати всі спільні поля, властивості, методи, наприклад, максимальна швидкість, «збільшити швидкість», «зменшити швидкість». 
//Розробити класи автомобілів з конкретною реалізацією конструкторів і методів.
//Створити делегат, який працює з об'єктами створених конкретних класів автомобилів і додати події в класи автомобилів. 
//Клас гри повинен випадковим чином генерувати склад машин, 
//які приймають участь в гонці і за допомогою розроблених делегатів управляти їх параметрами(випадковим чином), наприклад, впливати на швидкість руху.
//Гра закінчується, коли якийсь з автомобилів проїхав певну відстань (реалізувати за допомогою подій). 


    class Program
    {
        static Car[] cars = new Car[4];
        static int carNumber = 4;
        static int distance = 1000;
        static int[] carsDistance = new int[4];
        static void Main(string[] args)
        {
            FillCars();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"Race's distance: {distance} m");
                ShowCars();
                Console.Write($"1 - Move\n2 - Change\n0 - Exit\nYour choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Drive();
                        break;
                    case 2:
                        ChangeMenu();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        break;
                }
                for (int i = 0; i < carsDistance.Length; i++)
                {
                    if (carsDistance[i]>=distance)
                    {
                        Console.WriteLine($"Car N{i + 1} {cars[i].Type} won");
                        exit = true;
                        break;
                    }
                }              
            }           
        }

        static void ChangeMenu()
        {
            Console.WriteLine("1 - Stop\n2 - Speed down\n3 - Speed up");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter car's number");
                    carNumber = int.Parse(Console.ReadLine());
                    cars[--carNumber].RegisterToChange(FullStop);
                    cars[carNumber].Change();
                    break;
                case 2:
                    Console.WriteLine("Enter car's number");
                    carNumber = int.Parse(Console.ReadLine());
                    cars[--carNumber].RegisterToChange(SpeedDown);
                    cars[carNumber].Change();
                    break;
                case 3:
                    Console.WriteLine("Enter car's number");
                    carNumber = int.Parse(Console.ReadLine());
                    cars[--carNumber].RegisterToChange(SpeedUp);
                    cars[carNumber].Change();
                    break;
                default:
                    break;
            }
        }

        static void FillCars()
        {
            Random random = new Random();
            for (int i = 0; i < cars.Length; i++)
            {
                int choice = random.Next(1, 4);
                cars[i] = RandCar(choice);
            }
        }

        static void ShowCars()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                cars[i].ShowCar();
                Console.WriteLine($"    Drove distance: {carsDistance[i]} m");
            }
        }

        static Car RandCar(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new SportCar();
                case 2:
                    return new LightCar();
                case 3:
                    return new HeavyCar();
                case 4:
                    return new Bus();
                default:
                    return null;
            }
        }

        static void Drive()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Move();
                carsDistance[i] += cars[i].CurrentSpeed;
            }
        }

        private static void FullStop()
        {
            cars[carNumber].Stop();
        }

        private static void SpeedDown()
        {
            cars[carNumber].Break();
        }

        private static void SpeedUp()
        {
            cars[carNumber].Accel();
        }
    }
}
