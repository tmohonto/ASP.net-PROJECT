using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace kidslearningsystem.com
{
    public partial class loginpage : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source = DESKTOP-2NLFKOS; Initial Catalog = signup; Integrated Security = true";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from reg where email='" + textBox1.Text + "' and pass ='" + textBox2.Text + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "reg");

            if(ds.Tables[0].Rows.Count > 0)
            {
                Label4.Text = "data is found";
                Response.Redirect("homepage.aspx");
            }
            else
            {
                Label4.Text = "Data is not found";
            }
        }
    }
}