using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating Employee class; initalizing new object w/values:
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee1.SayName();
            Console.ReadLine();
        }
    }
}
