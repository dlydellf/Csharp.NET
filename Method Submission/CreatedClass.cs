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
        public static int createdMethod(int numb1, int numb2 = 4321) // "numb1" is User input, "numb2" is optional
        {
            int product = numb1 * numb2; // calculation
            Console.WriteLine($"{numb1} x {numb2} = {product}"); // its result
            Console.ReadLine(); // keeps console open for User's viewing
            return product; // method must return an <int>
        }
    }
}
