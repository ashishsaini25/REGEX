using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public  class Pattern
    {
        public static string password = "^[0-9A-Za-z@#$%^&*_-]{0,7}[A-Z]{1}[0-9A-Za-z@#$%^&*_-]*$";
        public bool Validate(string Password)
        {
            return Regex.IsMatch(Password,password);
        }
    }
}
