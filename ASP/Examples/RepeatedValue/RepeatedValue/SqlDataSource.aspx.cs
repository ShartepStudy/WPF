using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeatedValue
{
    public partial class SqlDataSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                // Замаскировать ошибку общим сообщением
                LabelError.Text = "Запрос не выполнен";

                // Предположить, что ошибка обработана
                e.ExceptionHandled = true;
            }
        }
    }
}