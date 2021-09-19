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
            // The required array (of strings):
            string[] phrases = { "1) Here's your entered text: ", "2) Here's your entered text: ", "3) Here's your entered text: ", "4) Here's your entered text: ", "5) Here's your entered text: ", "6) Here's your entered text: ", "7) Here's your entered text: " };
            Console.WriteLine("Please enter some text below:"); // User required to input some text
            string usersText = Console.ReadLine(); // User's input is saved to this string variable
            // Looping through each index of 
            foreach (string i in phrases)
            {
                Console.WriteLine(i + $"{usersText}"); // User's input is added to each index of array; loop prints each string on seperate line
            }
            Console.ReadLine();

            // PART 2:
            // [adding an infinite loop (j doesn't increment, so is ALWAYS < 10)]:
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
                Console.ReadLine();
            }

            // PART 3:
            // (required "<" loop):
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine($"{x} + 1 = {x + 1}. Again!");
                x++;
            }
            Console.WriteLine("Ok, enough of that.");
            Console.ReadLine();
            // required ">" loop:
            int y = 10;
            while (y > 0)
            {
                Console.WriteLine($"{y} - I don't like displaying that number; I'll decrease it by 1");
                Console.ReadLine();
                y--;
            }
            Console.WriteLine("Zero - I like displaying that number, even as a string!");
            Console.ReadLine();


            // PART 4:
            // (required list of unique strings):
            List<string> officeStuff = new List<string>();
            officeStuff.Add("desks");
            officeStuff.Add("chairs");
            officeStuff.Add("tables");
            officeStuff.Add("computers");
            officeStuff.Add("air vents");
            officeStuff.Add("people");
            officeStuff.Add("carpet");
            officeStuff.Add("windows");
            officeStuff.Add("stuff");

            Console.WriteLine(officeStuff);
            Console.ReadLine();
        }
    }
}
