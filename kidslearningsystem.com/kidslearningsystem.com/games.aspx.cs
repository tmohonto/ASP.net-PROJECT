using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kidslearningsystem.com
{
    public partial class games : System.Web.UI.Page
    {
        bool turn = true; //true = x; false = o;
        int turn_count = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["count"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ViewState["count"] = Convert.ToInt32(ViewState["count"]) + 1;

            int var = Convert.ToInt32(ViewState["count"]);
            if (var % 2 == 0)
            {
                b.Text = "0";
            }
            else
            {
                b.Text = "X";
            }
            turn_count = var;
            b.Enabled = false;
            checkForWinner();
        }
        
        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //Horizontal Checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //Vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //Diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                Response.Write("<script>alert('wins')</script>");
            }//end if
            else
            {
                if (turn_count == 0)
                    Response.Write("<script>alert('draw')</script>");
            }
        }//end checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach
            }//end try
            catch { }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("games.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}