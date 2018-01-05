using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddTFSFeedback
{
    public partial class addfeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var url = Request.QueryString["u"];
            var project = Request.QueryString["p"];
            var user = Request.QueryString["user"];
            var pwd = Request.QueryString["pwd"];
            var title = Request.QueryString["t"];

            if (string.IsNullOrEmpty(url))
            {
                Response.Write("I am live~");
               return;
            }
            isRock.Toolbox.TFS.VstsClient vc = new isRock.Toolbox.TFS.VstsClient(url, project, user, pwd);
            var ret = vc.AddFeedback(title, "no body");
            Response.Write(ret);
            Response.End();
        }
    }
}