using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // принять данные формы серверного приложения,
            //открытой в браузере мобильного устройства
            string Name = TextBox1.Text;
            string Lastname = TextBox2.Text;
            string Country = TextBox3.Text;
            // Ответ сервера клиенту
            Label1.Text += Name + " " + Lastname + " " + Country;

        }
    }
}