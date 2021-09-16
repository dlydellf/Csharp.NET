using System;

namespace Daily_Report
{
    class Program
    {
        static void Main() // Program's entry point; 'static' = Main() can be called w/o an object; 'void' = Main() doesn't return anything
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n\n"); // "Daily Report's" displayed headings
            Console.WriteLine("What is your name?"); // 1st required question
            string name = Console.ReadLine(); // Assigns 1st question's answer to a variable; saves according to its proper data type
            Console.WriteLine("\nWhat course are you on?"); // 2nd required question
            string courseName = Console.ReadLine(); // Assigns 2nd question's answer to a variable; saves according to its proper data type
            Console.WriteLine("\nWhat page number?"); // 3rd required question (can only return a STRING)
            string pageNum = Console.ReadLine(); // Assigns 3rd question's STRING answer to a TEMP variable for converting...
            int pageNumber = Convert.ToInt32(pageNum); // Converts 3rd's string -> INTEGER
            Console.WriteLine("\nDo you need help with anything?\nPlease answer \"true\" or \"false\"."); // 4th required question (can only return a STRING)
            string trueFalse = Console.ReadLine(); // Assigns 4th question's STRING answer to a TEMP variable for converting...
            bool needHelp = Convert.ToBoolean(trueFalse); // Converts 4th's string -> BOOLEAN
            Console.WriteLine("\nWere there any positive experiences you'd like to share?  Please give specifics."); // 5th required question
            string experiences = Console.ReadLine(); // Assigns 5th question's answer to a variable; saves according to its proper data type
            Console.WriteLine("\nIs there any other feedback you'd like to provide?  Please be specific."); // 6th required question
            string feedback = Console.ReadLine(); // Assigns 6th question's answer to a variable; saves according to its proper data type
            Console.WriteLine("\nHow many hours did you study today?"); // 7th required question (leaving as a string, since answer can vary widely)
            string hrsStudied = Console.ReadLine(); // Assigns 7th question's answer to a variable; saves according to its proper data type

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); // Keeps window open until User closes it

            /*
            // Displays all entered data for Instructor's review:
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Course: " + courseName);
            Console.WriteLine("Page: " + pageNumber);
            Console.WriteLine("Need Help (T/F)? " + needHelp);
            Console.WriteLine("Positive Experiences -> " + experiences);
            Console.WriteLine("Additional Feedback -> " + feedback);
            Console.WriteLine("Hours Studied: " + hrsStudied);
            Console.ReadLine();
            */
        }
    }
}
