using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Routes
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("", "", "~/WebForm1.aspx");
            routes.MapPageRoute("", "Page2", "~/WebForm2.aspx");
            routes.MapPageRoute("", "Book/{category}", "~/WebForm3.aspx");
            routes.MapPageRoute("404", "{*url}", "~/WebForm1.aspx");  //  PageNotFound.aspx
        }
    }
}