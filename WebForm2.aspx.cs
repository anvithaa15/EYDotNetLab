using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASP.NET_WA_Day_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection
               ("Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True"); //use double slash for path
     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //adding data to gridview
            con.Open();
            SqlDataAdapter s = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            s.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();

            //adding data to checkbox
            CheckBoxList1.DataSource = ds;
            CheckBoxList1.DataTextField = "empid";
            CheckBoxList1.DataBind();
            //adding data to radiobutton list
            RadioButtonList1.DataSource = ds;
            RadioButtonList1.DataTextField = "empname";
            RadioButtonList1.DataBind();
            //adding data to bulletlist
            BulletedList1.DataSource = ds;
            BulletedList1.DataTextField = "empsalary";
            BulletedList1.DataBind();
            //displaying selected date
            string datetme = Calendar1.SelectedDate.ToString();
            Response.Write(datetme);
            
        }

        
        protected void txtinsert_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        //insert
        protected void Button7_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(TextBox1.Text);
            string name = TextBox2.Text;
            int sal = int.Parse(TextBox3.Text);
            SqlCommand sq=new SqlCommand("insert into employee values('"+id+"','"+name+"','"+sal+"',100)",con);
            sq.ExecuteNonQuery();

        }

        //delete
        protected void txtdelete_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(TextBox4.Text);
            SqlCommand sq = new SqlCommand("delete from employee where empid='" + id + "'", con);
            sq.ExecuteNonQuery();
        }

        //update
        protected void txtupdate_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(TextBox6.Text);
            string name = TextBox5.Text;
            SqlCommand sq = new SqlCommand("update employee set empname='" + name + "' where empid='" + id + "'", con);
            sq.ExecuteNonQuery();
        }
    }
}