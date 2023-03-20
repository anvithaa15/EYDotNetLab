//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//using System.Data;
//using System.Data.SqlClient;

//namespace ASP.NET_WA_Day_1
//{
    
//    public partial class asp_demo1 : System.Web.UI.Page
//    {
//        SqlConnection con = new SqlConnection("Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True");
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }
//        //to connect database
//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            SqlConnection con = new SqlConnection
//                ("Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True"); //use double slash for path
//            con.Open();

//            Response.Write("connection is successful");
//        }

//        //protected void Button2_Click(object sender, EventArgs e)
//        //{
//        //    SqlConnection con = new SqlConnection("Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True");
//        //    con.Open();
//        //    SqlDataAdapter ad = new SqlDataAdapter("select * from employee", con);
//        //    DataSet ds = new DataSet();
//        //    ad.Fill(ds);

//        //    GridView1.DataSource = ds;
//        //    GridView1.DataBind();
//        //}

//        protected void Button3_Click(object sender, EventArgs e)
//        {
//        //    con.Open();
//        //    int id = int.Parse(txtempid.Text);
//        //    SqlCommand cmd = new SqlCommand("insert into employee(empid,empname,empsalary)") +
//        //                    "values(' " + id + " ' , '" + txtempname.Text + "' , '" + int.Parse(txtempsalary.Text) + "')", con);
//        //    cmd.ExecuteNonQuery();

//        //    Response.Write("insert succes");
//        //}

//        //protected void Button4_Click(object sender, EventArgs e)
//        //{

//        }

//        //protected void Button5_Click(object sender, EventArgs e)
//        //        {
//        //            //InsPanel.Visible = false;
//        //            //DelPanel.Visible = false;
//        //        }
//    }
//}
