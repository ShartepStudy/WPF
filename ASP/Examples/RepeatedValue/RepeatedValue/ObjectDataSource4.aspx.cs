using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeatedValue
{
    public partial class ObjectDataSource4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void sourceEmployees_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            if (e.Exception == null)
            {
                lblConfirmation.Text = "Вставлена запись " + e.ReturnValue.ToString() + ".";
            }
            else
            {
                lblConfirmation.Text = "Ошибка - Вы ввели все данные?";
                e.ExceptionHandled = true;
            }
        }

    }
}