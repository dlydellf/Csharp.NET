using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:\nNumber 1 = ....");
            int numb1 = Convert.ToInt32(Console.ReadLine()); // Converts & assigns User's 1st input to <int> "numb1"
            Console.WriteLine("(Optional) Please enter a 2nd number:\nNumber 2 = ...");
            int numb2 = Convert.ToInt32(Console.ReadLine()); // converts & assigns User's 2nd input to <int> "numb2"
            CreatedClass.createdMethod(numb1, numb2); // instantiating the class
        }
    }
}
