﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This prints the current date & time to the console:
            Console.WriteLine($"This is the current date & time:\n{DateTime.Now}");
            Console.WriteLine("\n(press Enter)");
            Console.ReadLine();

            // Asking the User for a number:
            Console.WriteLine("Please enter a number:");
            try
            {
                int UsersNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(UsersNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numbers");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
