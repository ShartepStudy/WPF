using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace home_work_26_09
{
    public partial class stepen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var res = Math.Pow(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            Label3.Text += res.ToString();
        }
    }
}