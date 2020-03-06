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
            //#region
            //int[,] matrix = new int[5, 5];
            //Random rand = new Random();
            //for (int i = 0; i < matrix.GetUpperBound(0)+1; i++)
            //{
            //    for (int j = 0; j < matrix.GetUpperBound(1)+1; j++)
            //    {
            //        matrix[i, j] = rand.Next(-100,100);

            //    }
            //}

            //for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            //    {
            //        Console.Write("[{0}]", matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //int min, max;
            //int minI=0, minJ=0;
            //int maxI=0, maxJ=0;
          

            //max = matrix[0, 0];
            //for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            //    {
            //        if (matrix[i, j] > max)
            //        {
            //            max = matrix[i, j];
            //            maxI = i;
            //            maxJ = j;
            //        }
                                      
            //    }
            //}


            //min = matrix[0, 0];
            //for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            //    {
            //        if (matrix[i, j] < min)
            //        {
            //            min = matrix[i, j];
            //            minI = i;
            //            minJ = j;
            //        }
                        
            //    }
            //}

            //int sum=0;

            //int maxQueue = maxI * (matrix.GetUpperBound(0) + 1) + maxJ;
            //int minQueue = minI * (matrix.GetUpperBound(0) + 1) + minJ;
            //int counter = 0;

            //Console.WriteLine($"Min queue: {minQueue}");
            //Console.WriteLine($"Max queue: {maxQueue}");

            //if (maxQueue>minQueue)
            //{
            //    for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            //    {
            //        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            //        {
            //            if (counter>minQueue && counter<maxQueue)
            //            {
            //                sum += matrix[i, j];
            //            }
            //            counter++;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            //    {
            //        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            //        {
            //            if (counter > maxQueue && counter < minQueue)
            //            {
            //                sum += matrix[i, j];
            //            }
            //            counter++;
            //        }
            //    }
            //}

           
            //Console.WriteLine("Min[i] = {0},Min[j] = {1}\nMax[i] = {2},Max[j] = {3}",minI, minJ,maxI,maxJ);
            //Console.WriteLine("Max: {0}\nMin: {1}\nSum: {2}", max, min,sum);

            //#endregion

            #region
            int[] arr = new int[30];
            int counter = 0, tmpcounter = 0;
            int first = 0, last = 0;

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {

                    tmpcounter++;
                }
                else
                {
                    if (counter < tmpcounter)
                    {
                        first = i - tmpcounter;
                        last = first + tmpcounter;
                        counter = tmpcounter;
                    }
                    tmpcounter = 0;
                }

            }

            Console.WriteLine($"Count growing digits: {counter}\nFirst index: {first}\nLast index: {last}");


            for (int i = first; i <= last; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            #endregion

        }
    }
}
