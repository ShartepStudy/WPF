using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlaceHolder
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Label lblSName = new Label();
                lblSName.ID = "lbl_SName";
                lblSName.Text = "Отчество: ";
                PlaceHolder1.Controls.Add(lblSName);
                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
                TextBox tbSName = new TextBox();
                tbSName.ID = "tb_SName";
                //PlaceHolder1.Controls.Add(tbSName);
                PlaceHolder1.Controls.Add(new LiteralControl("<br /><br />"));

                //tbSName.TextChanged += new System.EventHandler(this.tb_SName_TextChanged);
            }
        }
    }
}