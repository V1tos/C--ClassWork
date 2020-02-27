using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //string str = Console.ReadLine();
            //string reverseStr = new string(str.ToArray().Reverse().ToArray());
            //Console.WriteLine(reverseStr);
            #endregion

            #region
            //string str = Console.ReadLine();
            //string newStr = str.Insert(2, "BiG");
            //Console.WriteLine(newStr);
            #endregion

            #region
            //Random rand = new Random();

            //char[,] strMatrix = new char[3, 3];
            //string sumChars = "";

            //for (int i = 0; i < strMatrix.GetUpperBound(0)+1; i++)
            //{
            //    for (int j = 0; j < strMatrix.GetUpperBound(1) + 1; j++)
            //    {
            //        strMatrix[i, j] = Convert.ToChar(rand.Next(65,90));
            //        sumChars += strMatrix[i, j];
            //    }
            //}

            //for (int i = 0; i < strMatrix.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < strMatrix.GetUpperBound(1) + 1; j++)
            //    {
            //        Console.Write(strMatrix[i, j]);
            //    }
            //    Console.Write("\n");
            //}



            //Console.WriteLine(sumChars);
            //Console.Write("Enter your word: ");
            //string findWord = Console.ReadLine();

            //if (sumChars.Contains(findWord))
            //{
            //    Console.WriteLine("Finded word: {0}", findWord);
            //}
            //else
            //{
            //    Console.WriteLine("Didn't find word: {0}", findWord);
            //}
            #endregion

            #region

            //Console.Write("Enter any string: ");
            //string str = Console.ReadLine();

            //Console.Write("Choose changing word: ");
            //string choose = Console.ReadLine();

            //if (str.Contains(choose))
            //{
            //    Console.Write("Enter insert word: ");
            //    string insert = Console.ReadLine();
            //    str = str.Replace(choose, insert);
            //    Console.WriteLine("Change string: {0}", str);
            //}
            //else
            //{
            //    Console.WriteLine("Didn't find choosing word!!");
            //}



            #endregion

            Console.Write("Enter any string: ");
            string str = Console.ReadLine();

            
            string choose = " ";
            string choose1 = "  ";
            string choose2 = "   ";
            Console.Write("Enter insert word: ");
            string insert = Console.ReadLine();

            if (str.Contains(choose2))
            {
               
                str = str.Replace(choose2, insert);
               
            }
            if (str.Contains(choose1))
            {
                str = str.Replace(choose1, insert);

            }
            if (str.Contains(choose))
            {
                str = str.Replace(choose, insert);

            }
            else
            {
                Console.WriteLine("Didn't find choosing word!!");
            }
            Console.WriteLine("Change string: {0}", str);
        }
    }
}
