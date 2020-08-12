using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp4LoginApplication
{

    public class LoginLog
    {
        public string username;
        public string password;

        public LoginLog() { }

        public LoginLog(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}