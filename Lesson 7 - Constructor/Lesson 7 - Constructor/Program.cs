using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7___Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

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

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]<arr[i+1])
                {
                   
                   tmpcounter++;
                }
                else
                {
                    if (counter<tmpcounter)
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

        }


    }
}
