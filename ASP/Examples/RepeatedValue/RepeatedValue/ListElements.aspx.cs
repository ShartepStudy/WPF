using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeatedValue
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Создать источник данных
                Hashtable ht = new Hashtable();
                ht.Add("Key1", "Лазанья");
                ht.Add("Key2", "Спагетти");
                ht.Add("Key3", "Пицца");

                // Установить свойство DataSource элементов управления
                Select1.DataSource = ht;
                Select2.DataSource = ht;
                Listbox1.DataSource = ht;
                DropdownList1.DataSource = ht;
                CheckList1.DataSource = ht;
                OptionList1.DataSource = ht;

                // Привязать элементы управления
                Page.DataBind();
            }
        }

        protected void cmdGetSelection_Click(object sender, EventArgs e)
        {
            if (Select1.SelectedIndex != -1)
                Result.Text += "- Выбранный элемент в <b>Select1</b>: " +
                    Select1.Items[Select1.SelectedIndex].Text + " - " +
                    Select1.Value + "<br />";

            if (Select2.SelectedIndex != -1)
                Result.Text += "- Выбранный элемент в <b>Select2</b>: " +
                    Select2.Items[Select2.SelectedIndex].Text + " - " +
                    Select2.Value + "<br />";

            if (Listbox1.SelectedIndex != -1)
                Result.Text += "- Выбранный элемент в <b>Listbox1</b>: " +
                    Listbox1.SelectedItem.Text + " - " +
                    Listbox1.SelectedItem.Value + "<br />";

            if (DropdownList1.SelectedIndex != -1)
                Result.Text += "- Выбранный элемент в <b>DropdownList1</b>: " +
                    DropdownList1.SelectedItem.Text + " - " +
                    DropdownList1.SelectedItem.Value + "<br />";

            if (OptionList1.SelectedIndex != -1)
                Result.Text += "- Выбранный элемент в <b>OptionList1</b>: " +
                    OptionList1.SelectedItem.Text + " - " +
                    OptionList1.SelectedItem.Value + "<br />";

            if (CheckList1.SelectedIndex != -1)
            {
                Result.Text += "- Выбранный элемент в <b>CheckList1</b>: ";
                foreach (ListItem li in CheckList1.Items)
                {
                    if (li.Selected)
                        Result.Text += li.Text + " - " + li.Value + " ";
                }
            }
        }
    }
}