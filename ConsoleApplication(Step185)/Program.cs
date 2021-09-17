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
            Console.WriteLine($"Your input of {userInput}, multiplied by 50, equals...\n{answer}");
            Console.ReadLine();
        }
    }
}
