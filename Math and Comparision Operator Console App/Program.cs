using System;

namespace Math_and_Comparision_Operator_Console_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"); // this is program's 1st required output
            Console.WriteLine("\nPerson 1"); // program's 2nd required output
            Console.WriteLine("What is your hourly rate? (xxx.xx)"); // program's 1st required question for 'Person 1'
            string usersHourlyRate = Console.ReadLine(); // User's returned input will ALWAYS be a string; assigning the value to a variable for conversion...
            decimal hourlyRate = Convert.ToDecimal(usersHourlyRate); // converting User's string to more-specific 'decimal' data type
            Console.WriteLine("How many hours do you work per week? (xx.xx)"); // program's 2nd required question for 'Person 1'
            string usersWeeklyHours = Console.ReadLine(); // returned string assigned to a variable for converting...
            decimal weeklyHours = Convert.ToDecimal(usersWeeklyHours); // converting User's string to 'decimal' data type

            Console.ReadLine();

        }
    }
}
