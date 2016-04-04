using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WOB.Model;
using WOB.SQLDBDataAccess;

namespace WOB.PublicSiteController
{
    public class AdminLoginController : _BaseController
    {
        string ConnectionString;//local connectionstring to create a dataaccess instance
        public AdminLoginController(string connectionString) : base(connectionString) { ConnectionString = connectionString; }

        public int LoginAdmin(string UserName, string Password)
        {
            AdminDataAccess dAccess = new AdminDataAccess(ConnectionString);
            int AdminID = dAccess.GetAdminIDFromLogin(UserName, Password);
            return AdminID;
        }
    }
}
