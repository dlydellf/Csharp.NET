using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number createdNumberObject = new Number(); // creates object of dataType <Number>
            createdNumberObject.Amount = 1015.21m; // assigns an amount to newly created object
        }

        // created <struct> (named "Number") w/<decimal> property (called "Amount"):
        struct Number
        {
            public decimal Amount;
        }
    }
}
