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
                "Dau97nyYAzWCz9qbdoj1a+KMo4ka1oe8wp1EsXCvKagpaTpXCrhgYq/Vuq2hAUd0T3Zr+jc/UThviWjhWn5enxJSnqGcmPN2TiLz0jg6Yn0slE0obpVmqq0vi2A9v9dihvOpyV93IzyAoEeEOmwrkAdB04t89/1O/w1cDnyilFU=");
        }
    }
}