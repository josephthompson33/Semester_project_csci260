using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WOB.Model;
using WOB.SQLDBDataAccess;

namespace WOB.PublicSiteController
{
    public class CreateUserController : _BaseController
    {
        public CreateUserController(string connectionString) : base(connectionString) { SqlConConnectionString = connectionString; }

        public void insertUser(UserModel newUser)
        {
            UserDataAccess uda = new UserDataAccess(SqlConConnectionString);
            newUser.Password = EncryptPassword(newUser.Password);
            uda.InsertUser(newUser);
        }
        public bool emailAlreadyExists(string Email)
        {
            UserDataAccess uda = new UserDataAccess(SqlConConnectionString);
            if (uda.EmailAdressAlreadyExists(Email))
            {
                return true;
            }
            return false;
        }
    }
}