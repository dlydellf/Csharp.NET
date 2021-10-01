using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace MethodClass_Submission
{
    // Required class:
    class CreatedClass
    {
        // Required method; accepts two <int> parameters, does math to the 1st & displays the 2nd:
        public void createdMethod(int num1, int num2)
        {
            _ = num1 * 2021; // Math is done to 1st parameter, although result doesn't need to be displayed
            Console.WriteLine($"The 1st parameter, {num1}\nwas multiplied by the current year (2021).\nThe 2nd parameter is being displayed here: {num2}");
            Console.ReadLine();
        }
    }
}
