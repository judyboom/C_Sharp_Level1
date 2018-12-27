using System;
using System.Text.RegularExpressions;

namespace Task2
{
    public class Login
    {
        public string UserLogin { get; set; }

        public Login(string s)
        {
            UserLogin = s;
        }

        public bool IsCorrect()
        {

            if (UserLogin.Length < 2 || UserLogin.Length > 10 || char.IsDigit(UserLogin[0]))
                return false;
            
            for (int i = 0; i < UserLogin.Length; i++)
            {
                var code = Convert.ToInt32(UserLogin[i]);
                if (!
                    ((code >= Convert.ToInt32('a') && code <= Convert.ToInt32('z')) || 
                    (code >= Convert.ToInt32('A') && code <= Convert.ToInt32('Z')) || 
                    (code >= Convert.ToInt32('0') && code <= Convert.ToInt32('9')) 
                    ))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsCorrectRegEx()
        {
            return Regex.IsMatch(UserLogin, "^[a-z][a-zA-Z0-9]{1,9}$");
        }
    }
}
