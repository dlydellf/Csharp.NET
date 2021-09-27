using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_Submission
{
    class CreatedClass
    {
        // 1st required method: accepts (and adds) an <int> dataType ("numb1"), returning the answer as an <int> ("sum"):
        public static int RepeatedMethod(int numb1)
        {
            int sum = numb1 + 10; // addition is performed
            Console.WriteLine($"{numb1} + 10 = {sum}"); // displays result to console
            Console.ReadLine(); // console stays opened for User's review
            return sum;
        }

        // 2nd required method; same name, but accepts a <decimal> ("numb2")for subtraction:
        public static decimal RepeatedMethod(decimal numb2)
        {
            decimal difference = 100000 - numb2; // subtraction is performed
            Console.WriteLine($"\n100,000 - {numb2} = {difference}"); // displays answer to console
            Console.ReadLine(); // console stays opened until User closes it
            return difference;
        }

        // 3rd required method; accepts a <string> ("numb3"), converts it to an <int> for multiplication, and returns an <int> ("product"):
        public static int RepeatedMethod(string numb3)
        {
            try
            {
                int product = 50 * (Convert.ToInt32(numb3)); // converts <string> parameter to an <int>, then multiplies 50 by it; result == "product"
                Console.WriteLine($"50 x {numb3} = {product}"); // displays <int> "product" to console
                return product;
            }
            catch (FormatException)
            {
                int example = 5;
                Console.WriteLine($"Please enter a whole number (not text), like this:\nInstead of \"five\", enter {example}.");
                return example;
            }
            finally
            {
                Console.ReadLine(); // keeps console opened for User's viewing
            }
            
        }
    }
}
