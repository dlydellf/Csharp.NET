using System;

namespace Console_App_Submission
{
    class Program
    {
        // 1st Requirement: This while loop counts down from 20 to 0:
        static void Main()
        {
            int index = 20; // starting value of 20 assigned to int variable
            while (index > -1) // boolean condition: while index is greater than -1...
            {
                Console.WriteLine($"{index}"); // ...display index's value, 
                --index; // ...and decrement index by 1
            }
            Console.ReadLine(); // Window stays open to view result
        }

    }
}
