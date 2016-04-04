using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WOB.PublicSiteController;
using WOB.Model;
using System.Configuration;

namespace WOB.PublicSite
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bLogin_Click(object sender, EventArgs e)
        {
            UserLoginController con = new UserLoginController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            int UserID = con.loginUser(tbEmail.Text, tbPassword.Text);
            if(UserID != 0)
            {
                Session["CurrentUser_UserID"] = UserID;
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                Label1.Text = "invalid email or password";
            }
        }
    }
}