using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Inheritance
{
    // Required class:
    class Person
    {
        // Required <string> properties:
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Required void method:
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
