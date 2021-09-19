using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Pt1
{
    class Program
    {
        static void Main()
        {
            // PART 1:
            // Required array of strings:
            string[] phrases = { "This is String0", "This is String1", "This is String2", "This is String3", "This is String4", "This is String5", "This is String6" };
            Console.WriteLine("Please enter some text below:"); // User required to input some text
            string usersText = Console.ReadLine(); // User's input is saved to this string variable
            // Looping through each index of 
            foreach (string i in phrases)
            {
                Console.WriteLine(i + $"{usersText}"); // User's input is added to each index of array; loop prints each string on seperate line
            }
            Console.ReadLine();

            //PART 2:
            // Adding the required infinite loop (j doesn't increment, so is ALWAYS < 10):
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
                Console.ReadLine();
            }
        }
    }
}
