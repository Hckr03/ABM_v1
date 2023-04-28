using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    internal class ValidarSignIn
    {
        private string FirstName {  get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private string Email { get; set; } = string.Empty;
        private string Nickname { get; set; } = string.Empty;
        private string Dob { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;
        private string ConfirmPass { get; set; } = string.Empty;

        public Boolean valEmptyOrNull(string firstName, string lastName, string email, string nickname, string dob, string password, string confirmPass)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)
                || string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(confirmPass))
            {
                return true;
            }
            return false;
        }

        public Boolean valEmail(string email)
        {
            var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            return false;
        }
    }
}
