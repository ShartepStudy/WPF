using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBetweenPages
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Session.Add("data", "data_from_session");
            Response.Redirect("/Page2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("data");
            cookie.Value = "data_from_cookies";
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("/Page2.aspx");
        }
    }
}