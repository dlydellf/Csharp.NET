using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    // Required abstract class:
    public abstract class Person
    {
        // Required properties: 
        public string firstName { get; set; } // "public" == available throughout entire program
        public string lastName { get; set; } // "public" == available throughout entire program

        // Required method:
        public virtual void SayName() // "virtual" == inheritable & implementable (via overriding)
        {
            Console.WriteLine($"Your name's been recorded as:\n{this.firstName} {this.lastName}");
            Console.ReadLine();
        }
    }
}
