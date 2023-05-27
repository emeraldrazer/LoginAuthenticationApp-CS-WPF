using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;

namespace LoginAuthenticationApp
{
    public class Verify
    {
        public static bool RegisterInfo(string fullname, string username, string email, string password)
        {
            if(string.IsNullOrEmpty(fullname) || string.IsNullOrWhiteSpace(fullname))
            {
                return false;
            }

            if(string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            foreach (char letter in fullname)
            {
                if (char.IsNumber(letter))
                {
                    return false;
                }
            }

            try
            {
                MailAddress address = new MailAddress(email);
                address = null;
            }
            catch
            {
                return false;
            }

            return true;

        }

        public static bool LoginInfo(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return true;
        }
    }
}
