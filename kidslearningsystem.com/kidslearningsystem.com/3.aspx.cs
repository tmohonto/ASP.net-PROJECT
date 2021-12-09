using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;

namespace kidslearningsystem.com
{
    public partial class _3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = Server.MapPath("audio/3.wav");
            s.PlaySync();
        }
    }
}