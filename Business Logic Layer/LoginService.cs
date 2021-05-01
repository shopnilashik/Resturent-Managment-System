using Resturent_Managment_System.Data_Access_Layer;
using Resturent_Managment_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Business_Logic_Layer
{
    class LoginService
    {
        LoginDataAccess loginDataAccess;
        public LoginService()
        {
            this.loginDataAccess = new LoginDataAccess();
        }
        public int LoginValidation(string username, string password)
        {
            User user = new User()
            {
                username = username,
                password = password
            };
            return loginDataAccess.UserLoginValidation(user);
        }
        public int AddNewUser(string username, string password, int usertype)
        {
           
            User user = new User()
            {
                username = username,
                password = password,
                userType = usertype
            };
            this.loginDataAccess = new LoginDataAccess();
            return this.loginDataAccess.AddUser(user);
        }
    }
}
