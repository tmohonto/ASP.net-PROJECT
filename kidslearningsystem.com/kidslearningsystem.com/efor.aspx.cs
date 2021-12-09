using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;

namespace kidslearningsystem.com
{
    public partial class efor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/e.wav");
            s.PlaySync();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/elephant.wav");
            s.PlaySync();
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/eagle.wav");
            s.PlaySync();
        }
    }
}