using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class BookCollection
    {
        List<Book> books;

        public BookCollection()
        {
            books = new List<Book>();
            books.Add(new Book { Id = 1, Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            books.Add(new Book { Id = 2, Name = "Отцы и дети", Author = "И. Тургенев", Price = 180 });
            books.Add(new Book { Id = 3, Name = "Чайка", Author = "А. Чехов", Price = 150 });
        }

        public List<Book> Books
        {
            get { return books; }
        }
    }
}