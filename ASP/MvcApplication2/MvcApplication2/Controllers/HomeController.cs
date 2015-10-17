using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
using MvcApplication2.Util;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // получаем из бд все объекты Book
        List<Book> _books = new BookCollection().Books;
        
        public ActionResult Index()
        {
            // передаем все полученный объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = _books;
            // возвращаем представление
            return View();
        }

        public ActionResult Info(int id)
        {
            Book book = _books.Find(x => x.Id == id);
            return View(book);
        }

        private DateTime getToday()
        {
            return DateTime.Now;
        }

        public string Square(int a = 10, int h = 3)
        {
            double s = a * h / 2;
            return "<h2>Площадь треугольника с основанием " + a +
                    " и высотой " + h + " равна " + s + "</h2>";
        }

        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Привет мир!</h2>");
        }

    }
}
