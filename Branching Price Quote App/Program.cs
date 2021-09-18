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
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day."); // if weight > 50, this error displays and program exits
            }
            else
            {
                Console.WriteLine("Please enter the package width:"); // User's 2nd required prompt
                int width = Convert.ToInt32(Console.ReadLine());// User's input returns a 'string'; this line converts it to 'int'
                Console.WriteLine("Please enter the package height:"); // User's 3rd required prompt
                int height = Convert.ToInt32(Console.ReadLine());// User's input returns a 'string'; this line converts it to 'int'
                Console.WriteLine("Please enter the package length:"); // User's 4th required prompt
                int length = Convert.ToInt32(Console.ReadLine());// User's input returns a 'string'; this line converts it to 'int'

                /* This code block:
                #1 - TOTALS package's dimensions; if > 50, displays the "too big" error msg.  If <= 50, then it...
                #2 - Calculates package's volume (L x W x H), multiplies that by its weight, divides answer by 100, & displays result as the PRICE QUOTE
                */
                string quote = width + height + length > 50 ? "Package too big to be shipped via Package Express.": $"Your estimated total for shipping this package is: ${((length * width * height) * weight / 100).ToString()}.00\nThank you!";
                Console.WriteLine(quote);
            }
            Console.ReadLine();
        }
    }
}
