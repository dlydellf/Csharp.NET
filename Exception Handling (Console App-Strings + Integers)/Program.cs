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
            //User's input returns a <string>; converts that into a <int>, & assigns to variable "divisor"
            int divisor = Convert.ToInt32(Console.ReadLine());
            foreach (int dividend in dividends) // foreach numb in <list>...
            {
                int quotient = dividend / divisor; //...divide by User input, assign answer to 'quotient'
                Console.WriteLine($"{dividend} divided by {divisor} = {quotient}"); // display results to console
            }
            Console.ReadLine();
        }
    }
}
