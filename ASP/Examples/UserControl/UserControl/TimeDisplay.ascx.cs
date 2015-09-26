using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControl
{
    public partial class TimeDisplay : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshTime();
        }

        protected void lnkTime_Click(object sender, EventArgs e)
        {
            RefreshTime();
        }

        public void RefreshTime()
        {
            if (format == null)
            {
                lnkTime.Text = DateTime.Now.ToLongTimeString();
            }
            else
            {
                lnkTime.Text = DateTime.Now.ToString(format);
            }

        }

        private string format;
        public string Format
        {
            get { return format; }
            set { format = value; }
        }


    }
}