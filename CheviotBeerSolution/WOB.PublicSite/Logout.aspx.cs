using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WOB.PublicSiteController
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["CurrentUser_UserID"] = null;
            Response.Redirect("Default.aspx?DisplayLogoutMessage=1", false);
        }
    }
}