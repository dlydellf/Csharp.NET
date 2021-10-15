using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:"); // prompts User to enter current day of the week
            DaysOfTheWeek enumDataTypeVariable = (DaysOfTheWeek)Convert.ToInt32(Console.ReadLine()); // User's <string> input converted & assigned to an <enum> variable dataType
        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
