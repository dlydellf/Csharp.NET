using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_Submission
{
    class CreatedClass
    {
        // 1st required class: accepts (and adds) an <int> dataType, rreturning the answer as an <int> ("sum"):
        public static int firstMethod(int numb1)
        {
            int sum = numb1 + 10; // addition is performed
            Console.WriteLine($"{numb1} + 10 = {sum}"); // displays result to console
            Console.ReadLine(); // console stays opened for User's review
            return sum;
        }

        // 2nd required class; same name, but accepts a <decimal> for subtraction:
        public static decimal firstMethod(decimal numb2)
        {
            decimal difference = 100000 - numb2; // subtraction is performed
            Console.WriteLine($"\n100,000 - {numb2} = {difference}"); // displays difference to console
            Console.ReadLine(); // console stays opened until User closes it
            return difference;
        }
    }
}
