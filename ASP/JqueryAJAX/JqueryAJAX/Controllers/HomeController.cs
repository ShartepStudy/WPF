using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAJAX.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActionLink()
        {
            //return new ContentResult()
            //{
            //    Content = "<h5>hello from ActionLink</h5>"
            //};
            return PartialView("_Partial1", 2);
        }

        [HttpPost]
        public ActionResult BeginForm(string name)
        {
            return new ContentResult()
            {
                Content = "<h5>hello " + name + " from ActionLink</h5>"
            };
        }
    }
}