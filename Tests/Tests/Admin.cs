using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    class Admin 
    {
        string Login;
        string Password;
        public Admin(string login,string Password)
        {
            SetLogin(login);
            SetPassword(Password);
        }

        public void SetLogin(string login)
        {
            Login = login;
        }
        public void SetPassword(string paswword)
        {
            Password = paswword;
        }
        public string GetLogin()
        {
            return Login;
        }
        public string GetPassword()
        {
            return Password;
        }
    }
}
