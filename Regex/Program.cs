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
            for (int i = 0; i < 10; i++)
            {
                string s = Console.ReadLine();
                bool ok = pattern.Validate(s);
                Console.WriteLine(ok);
            }
        }
    }
}
