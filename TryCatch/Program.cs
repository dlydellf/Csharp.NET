using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");  // User is asked for their age
            int age = Convert.ToInt32(Console.ReadLine());  // Converts User's age from a <string> & assins the value to the <int> variable "age"
            Console.WriteLine($"Your age was recorded as: {age}");
            Console.ReadLine();
        }
    }
}