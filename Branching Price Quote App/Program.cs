using System;

namespace Branching_Price_Quote_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // program's 1st required statement
            Console.WriteLine("Please enter the package weight:"); // User's 1st required prompt
            int weight = Convert.ToInt32(Console.ReadLine());// User's input returns a 'string'; this line converts it to 'int'

            Console.ReadLine();
        }
    }
}
