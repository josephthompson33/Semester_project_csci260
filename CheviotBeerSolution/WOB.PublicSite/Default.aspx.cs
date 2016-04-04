using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WOB.PublicSite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Current_UserID"] != null)
            {
                Label1.Text = Session["Current_UserID"].ToString();
            }
            if (Request.QueryString["DisplayLogoutMessage"] == "1")
            {
                lMessage.Text = "Have a nice day!";
            }
        }
    }
}