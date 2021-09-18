using System;
using System.Text;

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

            Console.WriteLine($"{start}{middle}{end}"); // concatenating the above
            Console.ReadLine();

            // toUpperCase():
            string before = "we were small letters, but now we're uppercase!"; // string to convert to uppercase
            string after = before.ToUpper(); // the conversion
            Console.WriteLine(after); // displays the result
            Console.ReadLine(); // keeps console opened to view result

            // Stringbuilder:
            StringBuilder paragraph = new StringBuilder(); // instanciating an instance ("paragrpah") of the StringBuilder class
            paragraph.Append("This is the first sentence. ");
            paragraph.Append(" This is the second sentence.\n");
            paragraph.Append("This is the fourth sentence. ");
            paragraph.Append(" What happened to the third sentence?\n");
            paragraph.Append("This is the fifth (and last) sentence.");
            Console.WriteLine(paragraph); // after appending above to paragrpah's end, display result in console
            Console.ReadLine(); // keeps console opened for viewing
        }
    }
}
