using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    // Objects will be instantiated from this class
    public class Employee
    {
        // every "Employee" class object has one <int> property, "Id" :
        public int Id { get; set; }

        public void DisplayId()
        {
            Console.WriteLine($"Id: {Id}");
        }

        // Required overloaded "EqualTo" method:
        public static bool operator == (Employee a, Employee b)
        {
            if (a.Id == b.Id)
            {
                return true;
            } else
            {
                return false;
            }
        }
        // Accompanying overloaded "!EqualTo" method (required for "==" method):
        public static bool operator != (Employee a, Employee b)
        {
            if (a.Id != b.Id)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
