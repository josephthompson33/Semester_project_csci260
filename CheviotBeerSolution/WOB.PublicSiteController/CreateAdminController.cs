using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WOB.SQLDBDataAccess;
using WOB.Model;

namespace WOB.PublicSiteController
{
    public class CreateAdminController : _BaseController
    {
        public CreateAdminController(string connectionString) : base(connectionString) { SqlConConnectionString = connectionString; }

        public void CreateAdmin(AdminModel newAdmin)
        {
            AdminDataAccess um = new AdminDataAccess(SqlConConnectionString);
            um.InsertUser(newAdmin);
        }
    }
}