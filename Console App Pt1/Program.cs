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
        {/*
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
            }
            Console.ReadLine();

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

            */
            // PART 4:
            // (required list of unique strings):
            List<string> officeStuff = new List<string> { "desks/tables", "chairs", "lights", "computers", "air vents", "people", "carpet", "windows", "stuff", "things"};

            Console.WriteLine("\nTry guessing 1 of the 10 'things' usually found within an 'OFFICE SETTING':"); // asks User for a searchable word
            string usersGuess = Console.ReadLine(); // saves User's guess to a 'string' variable
            // This loop checks every index of list for User's guess:
            for (int i = 0; i < officeStuff.Count; i++)
            {
                if (officeStuff[i].Contains(usersGuess)) // If current index's value matches User's guess (singular or plural)...
                {
                    Console.WriteLine($"\nCongrats, you guessed correctly!!\nYour guess is at Index {i},\nranking it #{i+1}!"); // ...then display the matching text's index.
                    Console.ReadLine(); // keeps console opened until User closes it
                    return; // below code is now unreachable
                } 
            }
            Console.WriteLine("\nSorry - that wasn't one of our answers\n:("); // Otherwise, advise User that their guess wasn't on list
            Console.ReadLine();
        }
    }
}

/*
for (i = 0; i < list.length; i++)
{
    if (word is found)
    {write ("You win!"), then EXIT}

}
OTHERWISE, after checking EVERY INDEX - write(word NOT found; try again) 
 */
