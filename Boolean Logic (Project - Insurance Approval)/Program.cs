using System;

namespace Boolean_Logic__Project___Insurance_Approval_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?"); // program's 1st required question
            string usersAge = Console.ReadLine(); // User's input returns as a string; saving to a variable for 'string -> int' conversion...
            int age = Convert.ToInt32(usersAge); // converting the string to a more appropriate data type

            Console.WriteLine("(Please answer with either \"True\" or \"False\")\nHave you ever had a DUI?"); // program's 2nd required question
            string anyDUIs = Console.ReadLine(); // User's input returns as a string; saving to a variable for 'string -> boolean' conversion...
            bool DUIs = Convert.ToBoolean(anyDUIs); // converting the string its more accurate data type

            Console.WriteLine("How many speeding tickets do you have?"); // program's 3rd required question
            string usersTickets = Console.ReadLine(); // saving User's input to a variable for another 'string -> int' conversion
            int tickets = Convert.ToInt32(usersTickets); // coverting the string to a more suitable data type
            Console.WriteLine($"you claim to have had {tickets} tickets - wow...");

            Console.ReadLine();
        }
    }
}
