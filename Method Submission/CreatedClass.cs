using System;
/* Commenting-out these unused Namespaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Method_Submission
{
    // Required class:
    class CreatedClass
    {
        // Required method; accepts 2 <int>s, does a calculation, & returns an <int>:
        public static int createdMethod(int num1, int num2 = 4321) // "num1" is User input, "num2" is optional
        {
            int product = num1 * num2; // required math operation
            Console.WriteLine($"{num1} x {num2} = {product}"); // its result
            Console.ReadLine(); // keeps console open for User's viewing
            return product; // method must return an <int>
        }
    }
}
