using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13___Data_grid_view
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Availiable { get; set; }
    }

    public class BookStore : IEnumerable 
    {
        List<Book> books = null;

        public BookStore()
        {
            books = new List<Book>()
            {
                new Book {Author = "A. Booday",Title = "Patterns",  Availiable = true },
                new Book {Author = "R. Martin",Title = "Clear code", Availiable = false },
                new Book {Author ="A. Troelsen",Title = ".NET 8.0",  Availiable = true }
            };
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}
