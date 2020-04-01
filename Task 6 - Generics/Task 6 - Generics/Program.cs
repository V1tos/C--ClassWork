using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6___Generics
{
    class Program
    {
// Створити узагальнюючий клас, який містить список елементів(List<T>) та реалізує роботу з ним,
// включаючи сортування.Клас описати за допомогою узагальнюючих алгоритмів Generics. Сортування реалізувати довільним методом
//(вибором, бульбашковим тощо).
//2. метод, який дозволяє підрахувати скільки разів кожне слово зустрічається в заданому тексті.
// Результат записати в колекцію Dictionary<TKey, TValue>.
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(32);
            list.Add(2);
            list.Add(15);
            list.Add(104);
            list.Add(9);
            list.Add(65);

            using (Elements elements = new Elements(list))
            {
                elements.SortList();
                foreach (var item in elements)
                {
                    Console.WriteLine(item);
                }
            }


            Dictionary<string, int> dict = new Dictionary<string, int>();

            string text = "Hello World Hello text it text Hello";
           
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    dict.Add(words[i], 1);
                }
                catch (ArgumentException)
                {
                    dict[words[i]] += 1;
                }
            }

            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }
        }
    }
}
