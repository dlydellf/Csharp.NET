using System;

namespace ConsoleApplication_Step185_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi!\n1st Question - What number would you like multiplied by 50?"); // the 1st requirement
            string userInput = Console.ReadLine(); // User's input can ONLY be a string; assigning to a variable, but needs conversion...
            int input = Convert.ToInt32(userInput); // converting User's string -> int (whole numbers from -2 billion to 2 billion)
            int answer = input * 50;// Stores (userInput x 50)
            Console.WriteLine($"Your input of {userInput}, multiplied by 50, equals...{answer}\n(Press \"Enter\" to continue, please)");
            Console.ReadLine();

            Console.WriteLine("\n2nd Question - What number would you like 25 added to?"); // the 2nd requirement
            string usersInput = Console.ReadLine(); // this will always be a string; assigned to a new variable for another conversion...
            int addend = Convert.ToInt32(usersInput); // converting User's string -> int
            int total = addend + 25;// Stores (userInput + 25)
            Console.WriteLine($"Your input of {usersInput}, increased by 25, is...{total}\n(\"Enter\" again, please)");
            Console.ReadLine();

            Console.WriteLine("\n3rd Question - What number would you like divided by 12.5?"); // the 3rd requirement
            string usersDividend = Console.ReadLine(); // assigning the string to a variable for its conversion...
            decimal dividend = Convert.ToDecimal(usersDividend); // converting User's string -> more-specific decimal
            decimal quotient = dividend / 12.5m; // stores (usersDividend / 12.5)
            Console.WriteLine($"Your input of {usersDividend}, divided by 12.5, is...\n{quotient}\n(\"Enter\"... press it)");
            Console.ReadLine();

        }
    }
}
