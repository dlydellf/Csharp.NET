﻿using System;
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

            
            // PART 5:
            // required list [duplicate strings are: "cell" & "phone", occurring individually & within "cellphone"; "insurance", occurring individually & within "car insurance"):
            List<string> bills = new List<string> { "mortage", "insurance", "car insurance", "cable", "internet", "cell", "phone", "cellphone", "gas", "water", "electrical", "credit card" };

            Console.WriteLine("Guess which of your 12 monthly bills is due today?"); // User is asked to search for text within <bills>
            string chosenBill = Console.ReadLine(); // Saves text to a <string> variable

            int billCounter = 0; // this counter records how many times <chosenBill> is found within <bills>
            List<int> billIndices = new List<int>(); // this empty <list> will hold <chosenBill>'s index locations

            // Loop that checks <bills> for User's entered text:
            for (int index = 0; index < bills.Count; index++) // As each index is reached...
            {
                if (bills[index].Contains(chosenBill)) // ...if <chosenBill> is found, 
                {
                    billIndices.Add(index);// ...add the index to <billIndices>,
                    billCounter++; // ...and increment counter by 1
                }
            }
            switch (billCounter) // <billCounter>'s value is compared against both cases...
            {
                 case 1: // ...for single bills, one index displays.
                    Console.WriteLine($"Your {chosenBill} bill was found once, at index {billIndices[0]}.");
                    Console.ReadLine();
                    break;
                case 2: // ...for multiple bills, BOTH indices display.
                    Console.WriteLine($"Your {chosenBill} bill was found more than once, at indices {billIndices[0]} & {billIndices[1]}.");
                    Console.ReadLine();
                    break;
                default: // User is advised of no matching bills
                    Console.WriteLine($"Congrats! You don't have a \"{chosenBill}\" bill to pay!");
                    Console.ReadLine();
                    break;
            }
            */

            // PART 6:
            // required list [duplicate strings are: "other", "additional" & "more"]:
            List<string> items = new List<string> { "first", "second", "other", "additional", "more", "more", "additional", "other", "last" };

            int indexOut = 0; // an index-identifier
            int innerPasses = 0; // 2nd loop's counter <-----------  TESTING / DELETE
            int foundBefore = 0; // a count of how often each string appears

            // The 1st, OUTER 'foreach' loop to evaluate <list>'s items:
            foreach (var item in items)
            {
                Console.WriteLine($"The 1st loop is at item: {item}"); // Record beginning of each OUTER LOOP iteration
                indexOut++; // Record each item's index during OUTER loop - g2g

                // The 2nd, INNER loop (making a 2nd pass to check for duplicate strings) - (NOT g2g!)
                foreach (var otherItems in items)
                {
                    Console.WriteLine($"THE 2nd LOOP IS AT ITEM: {otherItems}"); // Record beginning of each INNER LOOP iteration
                    innerPasses++; // Record each iteration of the INNER loop
                    if (otherItems == item) // When remaining items == string from 1st loop... (NOT exactly g2g!)
                    {
                        Console.WriteLine("\t\t<--------Item below is a NESTED LOOP match"); //.. announce it, then...
                        foundBefore++; //.. add +1 here
                    }
                    Console.WriteLine($"Item: {item}\nOuter Index:{indexOut}\nInner Loop:{innerPasses}\nSeen This Before?: {foundBefore}\n");
                }
            }
            Console.ReadLine();         
        }
    }
}