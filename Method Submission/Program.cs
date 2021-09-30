using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatedClass instantiatedClass = new CreatedClass(); // instatiating the class
            Console.WriteLine("Please enter a number\nto multiply by the default (4,321):");
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine()); // Tries converting (& assigning) User's 1st input to <int> "num1"
                CreatedClass.createdMethod(num1); // if SUCCESSFUL, calls the method with its 1st input
                Console.WriteLine("(Optional) Please enter a 2nd number\n(to multiply by your 1st number):");
                try
                {
                    int num2 = Convert.ToInt32(Console.ReadLine()); // Treis converting (& assigning) User's 2nd input to <int> "num2"
                    CreatedClass.createdMethod(num1, num2); // if SUCCESSFUL, calls mathod w/both inputs
                }
                catch (Exception ex) // catches ANY exceptions w/User's 2nd input
                {
                    Console.WriteLine($"{ex.Message}"); // displays any error messages to console
                    Console.ReadLine(); // keeps console opened for User's viewing
                }
            }
            catch (Exception ex) // catches ANY exceptions w/User's 1st input
            {
                Console.WriteLine($"{ex.Message}"); // displays any error messages to the console
                Console.ReadLine(); // keeps console opened for User's viewing
            }
            finally // regardless of code above, this codeblock ALWAYS runs:
            {
                Console.WriteLine("That's the end of this program - thanks!");
                Console.ReadLine();
            }
        }
    }
}