using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Models
{
    public class Purchase
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // имя и фамилия покупателя
        [Required(ErrorMessage="Обязательное поле")]
        //[StringLength(50, MinimumLength=5, ErrorMessage="Слишком короткое имя")]
        //[RegularExpression("regex", ErrorMessage="error regex")]
        //[Remote("Action", "Home", ErrorMessage="wrong custom validation")]
        public string Person { get; set; }

        [Range(1, 20, ErrorMessage="wrong count")]
        public int Count { get; set; }

        // адрес покупателя
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string Address { get; set; }
        // ID книги
        public int BookId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}