using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WOB.Model;
using WOB.SQLDBDataAccess;

namespace WOB.PublicSiteController
{
    public class UpdateUserController : _BaseController
    {
        public UpdateUserController(string connectionString) : base(connectionString) { SqlConConnectionString = connectionString; }
        public void updateUser(UserModel um)
        {
            UserDataAccess uda = new UserDataAccess(SqlConConnectionString);
            uda.UpdateUser(um);
        }
        public UserModel GetUser(int userID)
        {
            UserDataAccess uda = new UserDataAccess(SqlConConnectionString);
            UserModel CurrentUser = uda.GetUser(userID);
            return CurrentUser;
        }
    }
}