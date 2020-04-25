using ShifaClinic.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.Session
{
    public class Auth
    {
        int loggedInUserId;

        public bool validateLogin(string username, string password)
        {
            // login verification with database 
            loggedInUserId = 1;
            return false;
        }

        public string resetPassword(string username)
        {
            return "";
        }

        public User currentUser
        {
            get
            {
                return new User()
                {
                    id = 1,
                    fullName = "Sohail Arshad",
                    username = "sohailarshad",
                    email = "rmsohaila@gmail.com"
                };
            } //return loggedInUserId;
        }
    }
}
