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
            Console.WriteLine("What is your name?\n"); // 1st required question
            string name = Console.ReadLine(); // 1st question's answer assigned to a descriptive variable & saved according to its proper data type
            Console.WriteLine("What course are you on?\n"); // 2nd required question
            string courseName = Console.ReadLine(); // 2nd question's answer assigned to a descriptive variable & saved according to its proper data type

            // Displays all entered data, if User desires:
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your current course of study is: " + courseName);
            Console.ReadLine();
        }
    }
}
