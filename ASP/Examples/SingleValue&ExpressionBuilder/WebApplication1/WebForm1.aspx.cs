using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SingleValueExpressionBuilder
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        protected string GetFilePath()
        {
            return "http://red-fox.com.ua/wp-content/uploads/2012/05/A-08-015-Star-cat-Pic.jpg";
        }

        protected string FilePath
        {
            get { return "http://red-fox.com.ua/wp-content/uploads/2012/05/A-08-015-Star-cat-Pic.jpg"; }
        }
    }
}