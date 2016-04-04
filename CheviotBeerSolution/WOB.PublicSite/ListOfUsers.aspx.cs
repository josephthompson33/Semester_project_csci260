using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WOB.PublicSiteController;

namespace WOB.PublicSite
{
    public partial class ListOfUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // The 'GetUsers' function returns List<UserModel>

            ListOfUsersController con = new ListOfUsersController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());

            rUsers.DataSource = con.GetUsers();

            rUsers.DataBind();
        }
        protected void bDeleteUser_Click(object sender, EventArgs e)

        {

            Button bDeleteUser = (Button)sender;

            // Get the value from the Command Argument

            int userToDelete_UserID = int.Parse(bDeleteUser.CommandArgument);

            // Call the DeleteUser function in the UserListController class
            ListOfUsersController con = new ListOfUsersController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            con.DeleteUser(userToDelete_UserID);

        }
    }
}