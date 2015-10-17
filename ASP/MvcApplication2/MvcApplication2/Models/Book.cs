using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class Book
    {
        // ID книги
        [Display(Name = "ID")]
        public int Id { get; set; }
        // название книги
        [Display(Name = "Название")]
        public string Name { get; set; }
        // автор книги
        [Display(Name = "Автор")]
        public string Author { get; set; }
        // цена
        [Display(Name = "Цена")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
    }
}