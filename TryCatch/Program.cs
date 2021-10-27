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
                if (age > 0)  // as long as User's age is greater than zero...
                { //... this code block executes.
                    int birthYear = DateTime.Today.Year - age;  // assigns (current year - User's age) to the <int> variable "birthYear"
                    Console.WriteLine($"Your year of birth was: {birthYear}");  // displays User's year of birth to the console
                }
                else  // if User's age is LESS THAN (or EQUAL TO) zero...
                {
                    throw new ImpossibleException();  //... this SPECIFIC exceotion is thrown/created (Line 27)
                }                
            }
            catch (ImpossibleException)
            {
                Console.WriteLine("Your age cannot be zero or below.");
            }
            catch (Exception)  // All other exceptions (Format, Overflow, etc.) arethrow this GENERAL exception:
            {
                Console.WriteLine("An error occurred - please contact your System Administrator.");
            }
            finally
            {
                Console.ReadLine();  // console remains opened for viewing
            }
        }
    }
}