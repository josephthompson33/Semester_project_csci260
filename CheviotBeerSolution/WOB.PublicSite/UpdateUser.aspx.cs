using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WOB.Model;
using WOB.PublicSiteController;

namespace WOB.PublicSite
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["CurrentUser_UserID"] == null) { Response.Redirect("Login.aspx", false); }

            else
            {
                UpdateUserController con = new UpdateUserController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
                UserModel CurrentUser = new UserModel();
                CurrentUser.UserID = int.Parse(Session["CurrentUser_UserID"].ToString());
                CurrentUser = con.GetUser(CurrentUser.UserID);
                tbEmail.Text = CurrentUser.Email;
                tbFirstName.Text = CurrentUser.FirstName;
                tbLastName.Text = CurrentUser.LastName;
            }
        }

        protected void bChange_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.UserID = int.Parse(Session["CurrentUser_UserID"].ToString());
            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.Email = tbEmail.Text;
            user.Password = tbPassword.Text;
            UpdateUserController con = new UpdateUserController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            con.updateUser(user);
            Response.Redirect("UpdateUser.aspx", false);
        }
    }
}