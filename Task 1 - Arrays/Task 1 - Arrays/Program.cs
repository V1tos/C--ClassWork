using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Arrays
{
    class Program
    {

        //1. Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
        //Определить сумму элементов массива, расположенных
        //между минимальным и максимальным элементами.
        //2. Заполнить массив случайными числами, вывести его на экран.Найти
        //самую длинную последовательность чисел, упорядоченную по
        //возрастанию.Вывести ее на экран.Если таких последовательностей
        //несколько (самых длинных с одинаковой длиной), то вывести их все.
        static void Main(string[] args)
        {

            int[,] matrix = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < matrix.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1)+1; j++)
                {
                    matrix[i, j] = rand.Next(-100,100);

                }
            }

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write("[{0}]", matrix[i, j]);
                }
                Console.WriteLine();
            }


            int min, max;
            int minI=0, minJ=0;
            int maxI=0, maxJ=0;

            max = matrix[0, 0];
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                                      
                }
            }


            min = matrix[0, 0];
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minI = i;
                        minJ = j;
                    }
                        
                }
            }

            int sum=0;

            //for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            //    {
            //        if (i>=minI && matrix[i, j] <= max)
            //        {
            //            sum += matrix[i, j];

            //        }

            //    }
            //}

            Console.WriteLine("{0},{1}\n{2},{3}",minI, minJ,maxI,maxJ);
            Console.WriteLine("Max: {0}\nMin: {1}\nSum: {2}", max, min,sum);
            

        }
    }
}
