using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthenticationApp.Http
{
    class LoginInfo
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginInfo(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }

    class LoginResponse
    {
        public Result result { get; set; }
        public string token { get; set; }
        public bool error { get; set; } = false;
        public string message { get; set; } = string.Empty;
    }

    public class Result
    {
        public Data[] data { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
    }

    class RegisterInfo
    {
        public string fullname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public RegisterInfo(string username, string password, string fullname, string email)
        {
            this.username = username;
            this.password = password;
            this.fullname = fullname;
            this.email = email;
        }
    }

    class RegisterResponse
    {
        public bool error { get; set; }
        public string message { get; set; }
    }

    class UserInfoResponse
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool error { get; set; } = false;
        public string message { get; set; } = string.Empty;
    }
}
