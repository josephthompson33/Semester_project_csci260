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
    public partial class CreateAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bSubmit_Click(object sender, EventArgs e)
        {
            AdminModel newAdmin = new AdminModel();
            newAdmin.userName = tbUserName.Text;
            newAdmin.password = tbPassword.Text;
            CreateAdminController Acon = new CreateAdminController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            Acon.CreateAdmin(newAdmin);
            Label1.Text = " new Admin User Created.";
        }
    }
}