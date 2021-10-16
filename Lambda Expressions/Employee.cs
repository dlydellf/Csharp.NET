using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    public class Employee
    {

        // a "constructor" for employee objects; each object inherits the fName/lName/Id props
        public Employee()
        {
        }
        // Required firstName/lastName/Id properties:
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; set; }
    }
}
