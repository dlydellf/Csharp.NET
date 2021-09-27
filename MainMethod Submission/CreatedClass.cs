using System;
/* commenting-out these unused Namespaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace MainMethod_Submission
{
    class CreatedClass // required class
    {
        // 1st required method: accepts (and adds) an <int> dataType ("numb1"), returning the answer as an <int> ("sum"):
        public static int RepeatedMethod(int numb1)
        {
            int sum = numb1 + 10; // addition is performed
            Console.WriteLine($"1) {numb1} + 10 = {sum}"); // displays result to console
            Console.ReadLine(); // console stays opened for User's review
            return sum; // method MUST return an <int> dataType
        }

        // 2nd required method; same name, but accepts a <decimal> ("numb2")for subtraction:
        public static decimal RepeatedMethod(decimal numb2)
        {
            decimal difference = 100000 - numb2; // subtraction is performed
            Console.WriteLine($"\n2) 100,000 - {numb2} = {difference}"); // displays answer to console
            Console.ReadLine(); // console stays opened until User closes it
            return difference; // method MUST return a <decimal> dataType
        }

        // 3rd required method; accepts a <string> ("numb3"), converts it to an <int> for multiplication, and returns an <int> ("product"):
        public static int RepeatedMethod(string numb3)
        {
            // This try/catch block keeps console opened regardless if 1 specific exception is raised (or any others):
            try
            {
                int product = 50 * (Convert.ToInt32(numb3)); // converts <string> parameter to an <int>, then multiplies 50 by it; result == "product"
                Console.WriteLine($"3) 50 x {numb3} = {product}"); // displays <int> "product" to console
                return product; // method MUST return an <int> dataType
            }
            // Catches any FORMATTING exceptions (strings, decimals, flaots, etc.):
            catch (FormatException)
            {
                int example = 550; // used for error message & return purposes
                Console.WriteLine($"3) (Error #1) Please enter a whole number (not text), like this:\nInstead of \"five hundred fifty\", just enter \"{example}\".");
                return example; // method MUST return an <int> dataType
            }
            // Catches any OTHER exceptions (OutOfMemory, Overflow, OutOfRange, etc.):
            catch (Exception ex) // error message is saved to the variable "ex"
            {
                Console.WriteLine($"3) (Error #2) {ex.Message}"); // displays the error message to the console
                return 0;
            }
            finally // this is try/catch block's final output:
            {
                Console.ReadLine(); // keeps console opened for User's viewing
            }
            
        }
    }
}
