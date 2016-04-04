using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WOB.SQLDBDataAccess;

namespace WOB.PublicSiteController
{
    public class UserLoginController: _BaseController
    {
        public UserLoginController(string connectionString) : base(connectionString) { SqlConConnectionString = connectionString; }
        public int loginUser(string Email, string Password)
        {
            UserDataAccess uda = new UserDataAccess(SqlConConnectionString);
            Password = EncryptPassword(Password);
            int UserID = uda.GetUserIDFromLogin(Email, Password);
            return UserID;
        }
    }
}