﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kidslearningsystem.com
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("alphabet.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("alphabetwords.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("games.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("maths.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("anthem.aspx");
        }
    }
}