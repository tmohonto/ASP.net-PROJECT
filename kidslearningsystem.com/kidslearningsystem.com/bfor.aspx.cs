using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;

namespace kidslearningsystem.com
{
    public partial class bfor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/b.wav");
            s.PlaySync();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/bat.wav");
            s.PlaySync();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/ball.wav");
            s.PlaySync();
        }
    }
}