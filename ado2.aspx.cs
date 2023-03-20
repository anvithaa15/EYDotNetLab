using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace ASP.NET_WA_Day_1
{
    public partial class ado2 : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection
                ("Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True"); //use double slash for path
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //1st way-
            SqlCommand cmd = new SqlCommand("select * from employee", con);

            //gridview.datasource=cmd.executereader();
            //gridview.databind();

            //2nd way-
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Response.Write(rdr[0]+"  "+rdr[1]+"   "+rdr[2]);
                Response.Write(rdr["empid"] + "  " + rdr["empname"] + "   " + rdr["empsalary"]);
            }
        }
    }
}