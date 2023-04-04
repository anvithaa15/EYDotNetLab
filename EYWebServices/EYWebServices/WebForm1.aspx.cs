using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace EYWebServices
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient s1 = new ServiceReference1.WebService1SoapClient();

            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            
            //Label3.Text = (s1.addition(a, b)).ToString();
            //Label3.Text = (s1.subtraction(a, b)).ToString();
            //Label3.Text = (s1.multiplication(a, b)).ToString();
            //Label3.Text = (s1.division(a, b)).ToString();

            //or

            int result = (s1.addition(a, b));
            //int result = (s1.multiplication(a, b));
            //int result = (s1.subtration(a, b));
            //int result = (s1.division(a, b));

            Label3.Text = result.ToString();

        }
    }
}