using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBetweenPages
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string res;
            if(!String.IsNullOrEmpty(Request.QueryString.Get("data")))
            {
                res = String.Format("Данные [{0}] полученные из QueryString.", Request.QueryString.Get("data"));
            }
            else if (this.Session["data"] != null)
            {
                res = String.Format("Данные [{0}] полученные из Session.", this.Session["data"]);
                this.Session.Remove("data");
            }
            else if (Request.Cookies["data"] != null)
            {
                res = String.Format("Данные [{0}] полученные из Cookies.", Request.Cookies["data"].Value);
                //HttpCookie cookie = Request.Cookies["data"];
                //cookie.Expires = DateTime.Now - new TimeSpan(1, 0, 0, 0);
                //Response.Cookies.Add(cookie);
            }
            else
            {
                res = "Никаких данных не получено";
            }
            Label1.Text = res;
        }
    }
}