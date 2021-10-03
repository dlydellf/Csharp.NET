using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Class_Submission
{
    // Required "static" class (unable to be instantiated)
    static class StaticClass
    {
        public static void staticClassMethod()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}!");
            Console.ReadLine();
        }
    }
}
