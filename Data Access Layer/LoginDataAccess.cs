using Resturent_Managment_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Data_Access_Layer
{
    class LoginDataAccess : DataAccess
    {
        public int UserLoginValidation(User user)
        {

            string sql = "SELECT * FROM users WHERE username='" + user.username + "' AND password='" + user.password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["usertype"]); ;
            }
            return -1;
        }
        public int AddUser(User user)
        {
            string sql = "INSERT INTO users(username,password,usertype) VALUES('" + user.username + "'," + user.password + "," + user.userType + ")";
            return this.ExecuteQuery(sql);
        }
    }
}
