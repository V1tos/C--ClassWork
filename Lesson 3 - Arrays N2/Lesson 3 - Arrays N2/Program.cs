using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3___Arrays_N2
{

    //Объявить одномерный(5 элементов ) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.
    //Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов.
    //Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы.
    //Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, 
    //общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.

    class Program
    {

        static double MatrixMaxElement (double[,] matrix)
        {
            double max = matrix[0, 0];
            for (int i = 0; i < matrix.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];             
                }
            }

            return max;
        }
        static double MatrixMinElement(double[,] matrix)
        {
            double min = matrix[0, 0];
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (matrix[i, j] < min) min = matrix[i, j];
                }
            }

            return min;
        }

        static void FillMatrix(double[,] matrix)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    matrix[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
                }
            }
        }

        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter count N{0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}]",array[i]);
            }
        }

        static void ShowMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write("[{0}]", matrix[i,j]);
                }
                Console.Write("\n");
            }

        }

        static int SumArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static double SumMatrix(double[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    sum += matrix[i, j];
                }          
            }

            return sum;
        }


        static int SumPairArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i%2==0)
                {
                    sum += array[i];
                }             
            }

            return sum;
        }

        static double SumPairMatrix(double[,] matrix)
        {
            double sum = 0;

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (j%2!=0)
                    {
                        sum += matrix[i, j];
                    }
                    
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int aSize = 5;
            int bRow = 3, bCol = 4;

            int[] arrayA = new int[aSize];
            double[,] arrayB = new double[bRow, bCol];

            FillArray(arrayA);
            FillMatrix(arrayB);

            Console.WriteLine("-------------Array A--------------");
            ShowArray(arrayA);
            Console.WriteLine("\n-------------Array A--------------\n");

            Console.WriteLine("-------------Array B--------------");
            ShowMatrix(arrayB);
            Console.WriteLine("-------------Array B--------------\n");

            Console.WriteLine("Max element in array A: {0}", arrayA.Max());
            Console.WriteLine("Max element in array B: {0}\n", MatrixMaxElement(arrayB));

            Console.WriteLine("Min element in array A: {0}", arrayA.Min());
            Console.WriteLine("Min element in array B: {0}\n", MatrixMinElement(arrayB));

            Console.WriteLine("Sum elements in array A: {0}", SumArray(arrayA));
            Console.WriteLine("Sum elements in array B: {0}\n", SumMatrix(arrayB));

            Console.WriteLine("Sum pair elements in array A: {0}", SumPairArray(arrayA));
            Console.WriteLine("Sum unpair column elements in array B: {0}\n", SumPairMatrix(arrayB));

        }
    }
}
