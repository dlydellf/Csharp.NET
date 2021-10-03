using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Inheritance
{
    // Required class, inheriting from class "Person":
    class Employee : Person
    {
        // Required property:
        public int Id { get; set; }
    }
}
