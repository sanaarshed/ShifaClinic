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

        public int currentUser
        {
            get { return 1; } //return loggedInUserId;
        }
    }
}
