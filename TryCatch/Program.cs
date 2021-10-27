using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");  // User is asked for their age
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());  // converts User's age from a <string> & assigns the value to the <int> variable "age"
                int birthYear = DateTime.Today.Year - age;  // assigns (current year - User's age) to the <int> variable "birthYear"
                Console.WriteLine($"Your year of birth was: {birthYear}");  // displays User's year of birth to the console
            }
            catch (Exception)  // Any exceptions are handled from this catch block:
            {
                Console.WriteLine("An error occurred - please contact your System Administrator.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}