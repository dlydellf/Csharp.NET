using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks User for a number:
            Console.WriteLine("Please enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your number ({answer}) has been recorded.");
            Console.ReadLine();

            // Logs the number to a text file (.txt):
            string text = Convert.ToString(answer);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Michell\Desktop\Trash Bin\log.txt", true))
            {
                file.WriteLine(text);
            }
        }
    }
}