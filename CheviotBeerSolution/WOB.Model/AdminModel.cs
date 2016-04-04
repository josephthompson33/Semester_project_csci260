using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WOB.Model
{
    public class AdminModel
    {
        public string userName;
        public string password;
        public int AdminID { get; set; }
        public AdminModel() { }
        public AdminModel(string UserName, string Password)
        {
            userName = UserName;
            password = Password;
        }
        void setName(string NewName)
        {
            userName = NewName;
        }
        string getName()
        {
            return userName;
        }
        string getPassword()
        {
            return password;
        }
        void setPassword(string newPassword)
        {
            password = newPassword;
        }
    }
}