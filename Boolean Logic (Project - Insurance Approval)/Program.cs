using System;

namespace Boolean_Logic__Project___Insurance_Approval_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?"); // program's 1st required question
            string usersAge = Console.ReadLine(); // User's input returns as a string; saving to a variable for 'string -> int' conversion...
            int age = Convert.ToInt32(usersAge); // casting the string to a more appropriate data type

            Console.WriteLine("(Please answer with either \"True\" or \"False\")\nHave you ever had a DUI?"); // program's 2nd required question
            string anyDUIs = Console.ReadLine(); // User's input returns as a string; saving to a variable for 'string -> boolean' conversion...
            bool DUIs = Convert.ToBoolean(anyDUIs); // casting the string its more accurate data type

            Console.WriteLine("How many speeding tickets do you have?"); // program's 3rd required question
            string usersTickets = Console.ReadLine(); // saving User's input to a variable for another 'string -> int' conversion
            int tickets = Convert.ToInt32(usersTickets); // casting the string to a more suitable data type

            /* Boolean logic is applied to three combined
             * rules to determine User's insurance qualification */
            bool qualified = age > 15 && DUIs == false && tickets <= 3;// Qualified if: 1) 16 or older, 2) has no DUIs, & 3) tickets =< 3
            Console.WriteLine($"Qualified?\n{qualified}");

            Console.ReadLine(); // window must be closed by User
        }
    }
}
