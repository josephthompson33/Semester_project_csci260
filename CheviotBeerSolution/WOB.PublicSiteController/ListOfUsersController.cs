using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WOB.SQLDBDataAccess;
using WOB.Model;

namespace WOB.PublicSiteController
{
    public class ListOfUsersController : _BaseController
    {
        public ListOfUsersController(string connectionString) : base(connectionString) { SqlConConnectionString = connectionString; }
        public List<UserModel> GetUsers()
        {
            UserDataAccess uda = new UserDataAccess(SqlConConnectionString);
            return uda.GetUsers();
        }
        public void DeleteUser(int userID)
        {
            UserDataAccess uda = new UserDataAccess(SqlConConnectionString);
            uda.DeleteUser(userID);
        }
    }
}