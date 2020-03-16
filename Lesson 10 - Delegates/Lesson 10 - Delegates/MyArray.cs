using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10___Delegates
{   
    class MyArray
    {

        public delegate void Changing();
        private Changing changeArray;

        public void RegisterToChange(Changing changeArray)
        {
            this.changeArray = changeArray;
        }

        int[] arr;

        public MyArray(int size)
        {
            arr = new int[size];
        }

        public void Fill()
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10,10);
            }
        }

        public void Change()
        {
            changeArray();
        }

        public int SumNegative()
        {
            int sumNegative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                    sumNegative += arr[i];
            }
            return sumNegative;
        }

        public int SumAll()
        {
            return arr.Sum();
        }

        public void ChangeToNull()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] = 0;
            }
        }

        public void Sort()
        {
            Array.Sort(arr);
        }

        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{arr[i]}] ");
            }
            Console.WriteLine();
        }    
    }
}
