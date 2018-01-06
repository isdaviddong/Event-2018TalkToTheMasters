using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testLineBot
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Utility.PushMessage("U6ca03b0fc595c152d361896126809a5f", 
                "test",
                "Fn2CdIjmBCz3kFdur9fiJX2pT84q74Uc6Vy3FxvrbnVd5qqc0GGvfquxHpvIdchsT3Zr+jc/UThviWjhWn5enxJSnqGcmPN2TiLz0jg6Yn3RCGwh4xebVTVHa6EpTucnOG5q1AHMEpdfkvfylauswQdB04t89/1O/w1cDnyilFU=");
        }
    }
}