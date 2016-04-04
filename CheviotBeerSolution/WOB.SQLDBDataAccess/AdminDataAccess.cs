using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WOB.Model;

namespace WOB.SQLDBDataAccess
{
    public class AdminDataAccess : DBAccess
    {
        public AdminDataAccess(string connectionString) : base(connectionString) { }
        // A function that inserts an Admin into the database.
        public void InsertUser(AdminModel newUser)
        {
            // Declare a new variable. Variable name is ‘sSQL’. Datatype is ‘string’.
            string sSQL = "";
            string UserName = newUser.userName;
            string Password = newUser.password;
            // Define the value for the ‘sSQL’ string variable.
            // Notice that this text is a SQL Query.
            sSQL += " INSERT INTO [Admin] ";
            // More columns will need to be added, depending on how many columns you have in your User table.
            // In this line, you need ALL the columns from your User table.

            // The word ‘Password’ is in brackets because it is a reserved word in SQL. 
            // We are hijacking that word and using it for our own purposes, so we need to put it in brackets.
            // Normally, SQL would try to interpret the word 'Password' differently than how we're using it.

            sSQL += " (UserName, [Password]) ";
            sSQL += " Values ";
            // The ‘@’ sign is a SQL Variable. It is connected to a SqlParameter (below).
            // This line needs to exactly match the list of columns in the User table.
            sSQL += " (@UserName, @Password) ";

            // Declare a new variable. Variable name is ‘sqlcomm’. Datatype is ‘SqlCommand’.
            SqlCommand sqlcomm = new SqlCommand();
            // Assign a value to the CommandText property.
            sqlcomm.CommandText = sSQL;

            // This SqlParameter constructor takes two arguments as input values.
            // Argument One: SQL Variable Name
            // Argument Two: Variable Value
            // The SqlParameter handles the declaration of the actual SQL Parameter in the T-SQL.
            SqlParameter sqlparam = new SqlParameter("@UserName", UserName);
            sqlcomm.Parameters.Add(sqlparam);

            // Notice that there is one ‘SqlParameter’ variable for each variable used in the SQL Query
            // More SqlParameter variables will need to be added for additional SQL variables.

            SqlParameter sqlparam1 = new SqlParameter("@Password", Password);
            sqlcomm.Parameters.Add(sqlparam1);
            // Execute the query.
            ExecNonQuery(sqlcomm);
        }
        // This function is called when a user tries to login to the website.
        // The function validates whether or not the username and password are correct.
        // If the username and password are correct, the UserID will be returned.
        // Otherwise, return 0.
        public int GetAdminIDFromLogin(string UserName, string Password)
        {
            string sql = " SELECT [AdminID] FROM [Admin] WHERE UserName = @UserName AND Password = @Password ";
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sql;
            SqlParameter sqlparam = new SqlParameter("UserName", UserName);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Password", Password);
            sqlcomm.Parameters.Add(sqlparam);

            object oAdminID = ExecScalar(sqlcomm);

            int AdminID = 0;

            if (oAdminID != null)

            {

                string sAdminID = oAdminID.ToString();

                if (string.IsNullOrEmpty(sAdminID) == false)

                {

                    AdminID = int.Parse(sAdminID);

                }

            }

            return AdminID;

        }
        public void DeleteAdmin(int AdminID)
        {
            string sSQL = " DELETE [AdminID] FROM [Admin] WHERE AdminID = @AdminID ";
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sSQL;
            ExecNonQuery(sqlcomm);
        }
        // This DataAccess function gets data for all Users from the database

        public List<AdminModel> GetAdmins()

        {

            // This is a SQL Query

            string sql = " SELECT AdminID, UserName, Password FROM [Admin] ";



            SqlCommand sqlcomm = new SqlCommand();

            sqlcomm.CommandText = sql;



            // Execute the SQL query

            DataTable dt = ExecReader(sqlcomm);



            // This is the variable that will be returned from the function.

            List<AdminModel> Admins = new List<AdminModel>();



            // Go through each row in the datatable.

            foreach (DataRow dr in dt.Rows)

            {

                // Get the data from the datatable

                AdminModel Admin = new AdminModel();

                Admin.AdminID = int.Parse(dr["AdminID"].ToString());

                Admin.userName = dr["UserName"].ToString();

                Admin.password = dr["Password"].ToString();



                // Add this User to the list

                Admins.Add(Admin);

            }



            return Admins;

        }
    }
}