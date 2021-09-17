using System;

namespace ConsoleApplication_Step185_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi!\n1st Question - What whole number would you like multiplied by 50?"); // the 1st requirement
            string userInput = Console.ReadLine(); // User's input can ONLY be a string; is assigned to a variable for conversion...
            int multiplicand = Convert.ToInt32(userInput); // converting User's string -> int (whole numbers from -2 billion to 2 billion)
            int product = multiplicand * 50;// storing (userInput x 50)
            Console.WriteLine($"Your input of {userInput}, multiplied by 50, equals... {product}\n(Press \"Enter\" to continue, please)");
            Console.ReadLine();

            Console.WriteLine("\n2nd Question - What whole number would you like 25 added to?"); // the 2nd requirement
            string usersInput = Console.ReadLine(); // this will always be a string; assigning it to a new variable for another conversion...
            int addend = Convert.ToInt32(usersInput); // converting User's string -> int
            int total = addend + 25;// storing (userInput + 25)
            Console.WriteLine($"Your input of {usersInput}, increased by 25, is... {total}\n(\"Enter\" again, please)");
            Console.ReadLine();

            Console.WriteLine("\n3rd Question - What number would you like divided by 12.5?"); // the 3rd requirement
            string usersDividend = Console.ReadLine(); // assigning the string to a variable for its conversion...
            decimal dividend = Convert.ToDecimal(usersDividend); // converting User's string -> more-specific decimal (since "12.5" isn't an int)
            decimal quotient = dividend / 12.5m; // stores (usersDividend / 12.5)
            Console.WriteLine($"Your input of {usersDividend}, divided by 12.5, is... {quotient}\n(\"Enter\" - press it)");
            Console.ReadLine();

            Console.WriteLine("\n4th Question - Choose a whole number, and we'll check whether or not it's greater than 50"); // the 4th requirement
            string usersChoice = Console.ReadLine(); // this variable is a string that will be converted...
            int userChoice = Convert.ToInt32(usersChoice); // converting usersChoice -> int
            bool answer = userChoice > 50;  // comparing usersChoice to 50
            Console.WriteLine($"\"Your choice of {usersChoice} is greater than 50\" -->> this statement is... {answer}\n(One more \"Enter\" keypress to go!)");
            Console.ReadLine();

            Console.WriteLine("\n5th Question - We'll divide a number by 7 for you, then show you its remainder - what number would you like to use?"); // the 5th requirement
            string userDividend = Console.ReadLine(); // number being divided is returned as a string & assigned to a variable for its conversion...
            decimal theDividend = Convert.ToDecimal(userDividend); // converting User's string -> more-specific decimal
            decimal theRemainder = theDividend % 7; // stores any reaminder from (theDividend / 7)
            Console.WriteLine($"Your input of {userDividend}, divided by 7, has a remainder of... {theRemainder}\n\nTanks for playing - Hope you enjoyed this!");
            Console.ReadLine();
        }
    }
}
