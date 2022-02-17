using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool ok= pattern.Validate("p17yggjvkj");
            Console.WriteLine(ok);  
        }
    }
}
