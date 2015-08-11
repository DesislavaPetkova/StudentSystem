using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class LoginValidation
    {
        private string _username;
        private string _password;
        public string errText { get; private set; }
        public LoginValidation(string username, string pass)
        {
            _username = username;
            _password = pass;
            errText = string.Empty;

        }
        public LoginValidation()
        {

        }
        private bool isTooShort(string s, int length)
        {
            if (s.Length >= length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ValidateUserInput(out User user)
        {
            user = null;
            if (isTooShort(_username, 5))
            {
                errText = "Invalid UserName";
                return false;
            }
            else if (isTooShort(_password, 5))
            {
                errText = "Invalid Password";
                return false;
            }
            else
            {
                User queryResult = UserData.IsUserPassCorrect(_username, _password);
                if (queryResult == null)
                {
                    errText += "Invalid username or password";
                    return false;
                }
                else
                {
                    user = queryResult;
                    return true;
                }
            }


        }
        public bool InsertUserIfValid(User u)
        {

            if (isTooShort(u.Username, 4))
            {
                errText = "Invalid username";
                return false;
            }
            if (isTooShort(u.Password, 4))
            {
                errText = "Invalid Password";
                return false;
            }
            if (isTooShort(u.FacNumber, 8))
            {
                errText = "Invalid Fak Number";
                return false;
            }
            return UserData.InsertUser(u);
        }
    }
}
