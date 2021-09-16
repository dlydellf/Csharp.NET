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
            string name = Console.ReadLine(); // 1st question's answer assigned to a descriptive variable & saved according to its proper data type
            Console.WriteLine("\nWhat course are you on?"); // 2nd required question
            string courseName = Console.ReadLine(); // 2nd question's answer assigned to a descriptive variable & saved according to its proper data type
            Console.WriteLine("\nWhat page number?"); // 3rd required question (can only return a STRING)
            string pageNum = Console.ReadLine(); // 3rd question's STRING answer assigned to a temp variable for converting
            int pageNumber = Convert.ToInt32(pageNum); // Converting STRING to an INTEGER for saving
            Console.WriteLine("\nDo you need help with anything?"); // 4th required question
            string needHelp = Console.ReadLine(); // 4th question's answer assigned to a descriptive variable & saved according to its proper data type

            // Displays all entered data, if User desires:
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Course: " + courseName);
            Console.WriteLine("Page: " + pageNumber);
            Console.WriteLine("Need Help?" + needHelp);
            Console.ReadLine();
        }
    }
}
