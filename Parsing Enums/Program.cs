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
            Console.WriteLine("Please enter the current day of the week:"); // prompts User to enter the current Day of the Week
            try
            {
                DaysOfTheWeek UsersInput = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine()); // User's <string> input ("Console.ReadLine();") is parsed & assigned to newly created <enum> dataType ("DaysOfTheWeek UsersInput")
                Console.WriteLine($"You entered {UsersInput} as the current day of the week"); // displays if (pseudocode) "DaysOfTheWeek.contains(UsersInput)"
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week"); // ANY exceptions will display this message
            }
            finally
            {
                Console.ReadLine();
            }
        }

        // an enum of the days of the week:
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