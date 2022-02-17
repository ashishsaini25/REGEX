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
        public static string lastname = "^[A-Z]{1}[a-z,A-Z,0-9]{2,}$";
        public bool Validate(string Firstname)
        {
            return Regex.IsMatch(Firstname, lastname);
        }
    }
}
