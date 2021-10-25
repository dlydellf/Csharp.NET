using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    public class Business
    {
        // The "Business" object's 1st CONSTRUCTOR (takes THREE arguments):
        public Business(string name, string location, int phone)
        {
            // assigns all arguments (name/location/phone) to class's already-defined properties (Name/Location/Phone):
            Name = name;
            Location = location;
            Phone = phone;
        }

        // The "Business" object's 2nd CONSTRUCTOR (takes ONE argument) INHERITS from the previous constructor, above:
        // These constructors are now "CHAINED TOGETHER":
        public Business(string name) : this(name, "USA", 999 - 999 - 9999)  // [assigns the "name" argument to the "Name" property (Line 27); "location" & "phone" have default values]
        {  // no inmplementation needed
        }

        // class's properties:
        public string Name { get; set; }
        public string Location { get; set; }
        public int Phone { get; set; }
    }
}