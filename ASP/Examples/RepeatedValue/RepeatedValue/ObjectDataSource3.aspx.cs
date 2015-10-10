using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeatedValue
{
    public partial class ObjectDataSource3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ObjectDataSource1_Updating(object sender, ObjectDataSourceMethodEventArgs e)
        {
            //EmployeeDetails ed = new EmployeeDetails(
            //    Convert.ToInt32(e.InputParameters["EmployeeID"]),
            //    e.InputParameters["FirstName"].ToString(),
            //    e.InputParameters["LastName"].ToString(),
            //    e.InputParameters["City"].ToString());
            //e.InputParameters["emp"] = ed;
            //e.InputParameters.Remove("EmployeeID");
            //e.InputParameters.Remove("FirstName");
            //e.InputParameters.Remove("LastName");
            //e.InputParameters.Remove("City");
        }
    }
}