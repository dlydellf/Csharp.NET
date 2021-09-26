using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What number would you like to perform math operations on?");
                int number = Convert.ToInt32(Console.ReadLine()); // User's input converts to dataType <int>

                Math_Operations.Adding(number); // calls class's 1st method
                Math_Operations.Multiply(number); // calls class's 2nd method
                Math_Operations.Divide(number); // calls class's 3rd method
                Console.WriteLine("\nYour chosen number has successfully been passed into three seperate methods as their input!");
            }
            catch (FormatException) // catches any "formatting" exceptions
            {
                Console.WriteLine("Please enter a whole number, no text nor decimals"); // displays this error messaage
            }
            catch (Exception ex) // catches any OTHER exceptions (Overflow, etc.)
            {
                Console.WriteLine(ex.Message); // displays this error message
            }
            finally
            {
                Console.ReadLine(); // this ALWAYS runs, no matter what
            }

        }
    }
}
