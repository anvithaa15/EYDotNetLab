using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2_wcf_
{
    public partial class WebForm1_wcf_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);

            ServiceReference.ServiceClient c1 = new ServiceReference.ServiceClient();

            Response.Write("addition result is: " + c1.addition(a, b));
        }
    }
}