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
            Console.WriteLine("Please select a number (0-4) to display the accompanying string from the array:");
            // User's chosen number is captured, converted from a string into an int, & assigned to an int-variable ("choice"):
            int choice = Convert.ToInt32(Console.ReadLine());
                // while loop used here, in lieu of a ternary:
                while (choice > 4) // If User chooses an index that doesn't exist...
                { // ...display this error message:
                    Console.WriteLine("\nAnother error-checking session; always a good idea!\nChoose a number between 0 & 4 when you're ready to move on:");
                    choice = Convert.ToInt32(Console.ReadLine()); //...and reassign the variable to their new choice
                }
            // ...otherwise, continue program as intended:
            Console.WriteLine($"\nHere's the string you chose:\n{stringArray[choice]}"); // Array's string (at User's chosen index) is displayed to the console
            Console.ReadLine(); // console remains opened for viewing



            // An array of integers, assigned to a int-variable ("intArray"):
            int[] intArray = { -2000000000, -1000, -1, 0, 2, 3, 4, 1999999999 };

            // Console displays this instruction to User:
            Console.WriteLine("Please select a number (0-7) to display the accompanying integer from the array:");
            // User's chosen number is captured, converted from a string into an int, & assigned to its own int-variable ("selection"):
            int selection = Convert.ToInt32(Console.ReadLine());
                // Another while loop for indexes that don't exist:
                while (selection > 7) // For selections outside the array's range...
                { //... display this error message:
                    Console.WriteLine("\nYour chosen number is outside of the acceptable range of 0 thru 7\nPlease select again:");
                    selection = Convert.ToInt32(Console.ReadLine()); //... and reassign their next choice to the same int-variable
                }
            // ...if index is found, program displays their choice:
            Console.WriteLine($"\nHere's your chosen intger: {intArray[selection]}");
            Console.ReadLine(); // console remains opened for viewing


            // A list of strings, assigned to a string-variable ("stringList"):
            List<string> stringList = new List<string>();
            stringList.Add("This is Index Position 0");
            stringList.Add("This is Index Position 1");
            stringList.Add("This is Index Position 2");
            stringList.Add("This is Index Position 3");
            stringList.Add("This is Index Position 4");
            stringList.Add("This is Index Position 5");

            // Console displays this instruction to User:
            Console.WriteLine("Please select a number (0-6) to display the accompanying string from the list:");
            // User's chosen number is captured, converted from a string into an int, & assigned to an int-variable ("pick"):
            int pick = Convert.ToInt32(Console.ReadLine());
            // while loop used again:
            while (pick > 6) // If User chooses an index that doesn't exist...
            { // ...display this error message:
                Console.WriteLine("\nWrong! 0 to 6, nothing else!\nChoose wiser this time.");
                pick = Convert.ToInt32(Console.ReadLine()); //...and reassign the variable to their new choice
            }
            // ...otherwise, continue program as intended:
            Console.WriteLine($"\nHere's the string you chose:\n{stringList[pick]}\nThanks for playing.  Goodbye"); // List's string (at User's chosen index) is displayed to the console
            Console.ReadLine(); // console remains opened for viewing
        }
    }
}
