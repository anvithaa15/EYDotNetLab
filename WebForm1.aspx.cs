using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_WA_Day_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox2.Text);
            int num2 = int.Parse(TextBox3.Text);

            Response.Write("addition result is: " + (num1 + num2));

            Response.Write("subtraction result is: " + (num1 - num2));

            Response.Write("multiplication result is: " + (num1 * num2));

            Response.Write("division result is: " + (num1 / num2));

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label6.Text = "selected city is : " + DropDownList1.SelectedItem.Text.ToString();
            //Label6.Text = "selected value is : " + DropDownList1.SelectedItem.Value.ToString();
            //Label6.Text = "selected index is : " + DropDownList1.SelectedItem.Text.ToString();

        }
    }
}