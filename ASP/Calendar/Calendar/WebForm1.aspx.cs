using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calendar
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblDates.Text = "You selected these dates:<br />";
            foreach (DateTime dt in Calendar1.SelectedDates)
            {
                lblDates.Text += dt.ToLongDateString() + "<br />";
            }

        }
    }
}