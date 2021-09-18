using System;

namespace String_Assignment
{
    class Program
    {
        static void Main()
        {
            // Concatenation:
            string start = "This IS "; // string 1 of 3
            string middle = "a concate"; // string 2 of 3
            string end = "nated sentence... trust me."; // string 3 of 3

            Console.WriteLine($"{start}{middle}{end}");
            Console.ReadLine();
        }
    }
}
