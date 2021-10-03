using System;
/* Commenting-out these unused NameSpaces:
 * using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatedClass instantiatedClass = new CreatedClass(); // instantiates an instance of the class
            try
            {
                Console.WriteLine("Please enter a number"); // User is asked to enter a number
                int num1 = Convert.ToInt32(Console.ReadLine()); // User's input is converted from a <string> to an <int>
                instantiatedClass.createdMethod(num1); // method is called with User's input
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                StaticClass.staticClassMethod(); // calls the static class's method
            }
        }
    }
}