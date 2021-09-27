using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatedClass.RepeatedMethod(50); // instantiated the "CreatedClass" class and called its sole method, passing in an <int>
            CreatedClass.RepeatedMethod(100.95m); // instantiated the "CreatedClass" class and called its 2nd method, passing in a <decimal>
            CreatedClass.RepeatedMethod("five hundred fifty"); // <--- error-checking
            CreatedClass.RepeatedMethod("9999999999999999999");// <--- error-checking
            CreatedClass.RepeatedMethod("500"); // <<<<<<< correct code
        }
    }
}
