using System;
using System.Collections.Generic;

namespace Exception_Handling__Console_App_Strings___Integers_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates required list of integers (List<int>); list is named "dividends":
            List<int> dividends = new List<int> { 100, 200, 300, 400, 500 };
            Console.WriteLine("Please enter a number to divide each integer by: "); // User's displayed instructions

            // This try/catch block displays proper error messages onto console:
            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine()); // Converts User's input from a <string> into an <int>; assigns to variable "divisor"
                foreach (int dividend in dividends) // foreach numb in <list>...
                {
                    int quotient = dividend / divisor; //...divide by User input, assign answer to 'quotient'
                    Console.WriteLine($"{dividend} divided by {divisor} = {quotient}"); // display results to console
                }
            }
            catch (FormatException ex) // catches ONLY 'FormatExceptions' --> assigns to dataType 'ex'
            {
                Console.WriteLine("\nPlease type a whole number - no letters."); // writes this error message to console
            }
            catch (DivideByZeroException ex) // catches ONLY 'DivideByZero' exceptions --> assigns to dataType 'ex'
            {
                Console.WriteLine("\nPlease don't divide by zero."); // writes this error message to console
            }
            catch (Exception ex) // catches ALL OTHER Exceptions --> assigns to dataType 'ex'
            {
                Console.WriteLine(ex.Message); // whatever the message is, display it to console
            }
            finally // runs NO MATTER WHAT!!!
            {
                Console.ReadLine();
            }
            Console.WriteLine("\nProgram has exited from its try/catch block & continued executing.");
            Console.ReadLine();
        }
    }
}
