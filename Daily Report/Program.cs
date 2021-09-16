using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main()
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

            // Displays all entered data, if User desires:
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Course: " + courseName);
            Console.WriteLine("Page: " + pageNumber);
            Console.WriteLine("Need Help (T/F)? " + needHelp);
            Console.ReadLine();
        }
    }
}
