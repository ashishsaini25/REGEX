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
        public static string password = "^(?=[a-zA-Z0-9#@$?]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$";
        public bool Validate(string Password)
        {
            return Regex.IsMatch(Password,password);
        }
    }
}
