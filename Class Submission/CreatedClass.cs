using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Class_Submission
{
    // Required class:
    class CreatedClass
    {
        // Required method; accepts an <int>, divides it by two, and outputs an <int>:
        public void createdMethod(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine($"Your entered numbeer, {num1}, divided by 2\nequals {result}");
            Console.ReadLine(); // keeps console opened for User's viewing
        }

        // Required method w/an output parameter:
        public void outputMethod(out string message)
        {
            string happyReminder = "It's Friday!!!";
            message = happyReminder;
            Console.WriteLine($"Today's Happy Reminder:\n{message}");
        }

        // Required "overloaded" method: same method (createdMethod), diff params (<int> & <string>)
        public void createdMethod(out string message)
        {
            string happyMessage = "It's not Monday!";
            message = happyMessage;
            Console.WriteLine($"Today's Happy Message:\n{message}");
        }
    }
}
