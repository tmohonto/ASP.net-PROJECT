using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;

namespace kidslearningsystem.com
{
    public partial class bangladeshanthem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/bangladeshanthem.wav");
            s.Stop();
            Response.Redirect("anthem.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/bangladeshanthem.wav");
            s.Play();
        }
    }
}