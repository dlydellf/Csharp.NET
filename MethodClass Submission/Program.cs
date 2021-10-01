using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace MethodClass_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatedClass instantiatedClass = new CreatedClass(); // instantiating an instance of the class
            instantiatedClass.createdMethod(10, 20); // calling the method w/2 parameters
            int num1;
            int num2;
            instantiatedClass.createdMethod(num1 = 12, num2 = 100); // calling the method again, w/both parameters specified by name(?)
        }
    }
}
