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
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bSubmit_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();

            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.Email = tbEmail.Text;
            user.Password = tbPassword.Text;
            CreateUserController con = new CreateUserController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            if (con.emailAlreadyExists(tbEmail.Text))
            {
                Label1.Text = "Email already in use, choose another please or login to your account";
            }
            else
            {
                con.insertUser(user);
                Label1.Text = "user successfully created. ";
                Response.Redirect("Default.aspx", false);
            }
        }
    }
}