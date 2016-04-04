using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WOB.PublicSiteController;
using WOB.Model;

namespace WOB.PublicSite
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bLogin_Click(object sender, EventArgs e)
        {
            AdminLoginController Acon = new AdminLoginController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            int AdminID = Acon.LoginAdmin(tbUserName.Text, tbPassword.Text);
            if (AdminID != 0)
            {
                Response.Redirect("AdminDefault.aspx", false);
            }
            else
            {
                Label1.Text = "invalid username and/or password";
            }
        }
    }
}