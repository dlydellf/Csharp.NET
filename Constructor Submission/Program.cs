using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Required <const> variable:
            const string myName = "Douglas";  // my 1st name is assigned to a <string> variable (named "myName"); since my 1st name will never change, the variable is also a <constant>
            Console.WriteLine($"My first name ({myName}) has been assigned to the constant variable \"myName\".");
            Console.ReadLine();
        }
    }
}
