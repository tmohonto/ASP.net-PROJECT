using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace kidslearningsystem.com
{
    public partial class registration : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source = DESKTOP-2NLFKOS; Initial Catalog = signup; Integrated Security = true";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into reg" + "(fname,lname,email,gender,address,phone,pass) values(@fname,@lname,@email,@gender,@address,@phone,@pass)", con);
            cmd.Parameters.AddWithValue("@fname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@lname", TextBox2.Text);
            cmd.Parameters.AddWithValue("@email", TextBox3.Text);
            cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@address", TextBox4.Text);
            cmd.Parameters.AddWithValue("@phone", TextBox5.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox6.Text);
            cmd.ExecuteNonQuery();
            Label1.Text = "signup inserted";
            Response.Redirect("loginpage.aspx");
        }
    }
}