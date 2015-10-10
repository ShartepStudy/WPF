using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeatedValue
{
    public partial class DataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string conectionStr = @"Server=tcp:wwo82585us.database.windows.net,1433;Database=aspnetdb;User ID=aspnetdb@wwo82585us;Password=asp_net_db_1;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
                SqlConnection connection = new SqlConnection(conectionStr);

                // Загрузить данные таблицы Employees в DataReader
                SqlCommand command = new SqlCommand(
                    "SELECT EmployeeID, FirstName + ' ' + LastName AS FullName FROM Employees", 
                    connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Привязать DataReader к списку
                    ListBox1.DataSource = reader;
                    ListBox1.DataBind();
                    reader.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        protected void cmdGetSelection_Click(object sender, EventArgs e)
        {
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                    Result.Text += String.Format("<li>({0}) {1}</li>", item.Value, item.Text);
            }

        }


    }
}