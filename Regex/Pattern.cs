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
        public static string mobilenumber = "^[0-9A-Za-z@#$%^&*_-]{8,}$";
        public bool Validate(string Mobilenumber)
        {
            return Regex.IsMatch(Mobilenumber,mobilenumber);
        }
    }
}
