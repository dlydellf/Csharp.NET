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
            string user1HourlyRate = Console.ReadLine(); // Person1's returned input will ALWAYS be a string; assigning the value to a variable for conversion...
            decimal hourlyRate1 = Convert.ToDecimal(user1HourlyRate); // converting Person1's string to more-specific 'decimal' data type
            Console.WriteLine("How many hours do you work per week? (xx.xx)"); // program's 2nd required question for 'Person 1'
            string user1WeeklyHours = Console.ReadLine(); // returned string assigned to a variable for converting...
            decimal weeklyHours1 = Convert.ToDecimal(user1WeeklyHours); // converting Person1's string to 'decimal' data type

            Console.WriteLine("\nPerson 2"); // program's 3rd required output
            Console.WriteLine("What is your hourly rate? (xxx.xx)"); // program's 1st required question for 'Person 2'
            string user2HourlyRate = Console.ReadLine(); // Person2's returned input will ALWAYS be a string; assigning the value to a variable for conversion...
            decimal hourlyRate2 = Convert.ToDecimal(user2HourlyRate); // converting Person2's string to more-specific 'decimal' data type
            Console.WriteLine("How many hours do you work per week? (xx.xx)"); // program's 2nd required question for 'Person 2'
            string user2WeeklyHours = Console.ReadLine(); // returned string assigned to a variable for converting...
            decimal weeklyHours2 = Convert.ToDecimal(user2WeeklyHours); // converting Person2's string to 'decimal' data type

            /* This code block calculates annual salaries:
             [(hourlyRate x hoursWorkedPerWeek) = weeklySalary] x 52 weeks = annual salary
            */
            decimal annualSalary1 = (hourlyRate1 * weeklyHours1) * 52;
            Console.WriteLine($"Annual salary of Person 1:\n{annualSalary1}");
            
            Console.ReadLine();

        }
    }
}
