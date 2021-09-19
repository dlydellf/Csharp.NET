using System;
using System.Collections.Generic;

namespace Console_App_Array_Submission
{
    class Program
    {
        static void Main()
        {
            // An array of strings, assigned to a string-variable ("stringArray"):
            string[] stringArray = { "Hello world", "Hi, world!", "Hello, Planet Earth!", "Hello there, Earthling", "Status 404: string not found" };
            
            // Console displays this instruction to User:
            Console.WriteLine("Please select a number (0-4) to display the accompanying string from the array: ");
            // User's chosen number is captured, converted from a string into an int, & assigned to an int-variable ("choice"):
            int choice = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(stringArray[choice]); // Array's string (at User's chosen index) is displayed to the console
            Console.ReadLine(); // console remains opened for viewing


            // An array of integers, assigned to a int-variable ("intArray"):
            int[] intArray = { -2000000000, -1000, -1, 0, 2, 3, 4, 1999999999 };

            // Console displays this instruction to User:
            Console.WriteLine("Please select a number (0-7) to display the accompanying integer from the array: ");
            // User's chosen number is captured, converted from a string into an int, & assigned to its own int-variable ("selection"):
            int selection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(intArray[selection]); // Array's integer (at User's chosen index) is displayed to the console
            Console.ReadLine(); // console remains opened for viewing
        }
    }
}
