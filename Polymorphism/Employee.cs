using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{ 
    public class Employee : Person, IQuittable // pprevious drill's "Employee" class inherits the new interface, "IQuittable"
    {
        public override void SayName() // this inherited virtual method is being overridden (thus implementing it)
        {
            base.SayName();
        }
        public void Quit() // implements the interfaces's Quit() method
        {
            Console.WriteLine("This text displays only if the \"Quit\" method\nhas been implemented successfully.");
            Console.ReadLine();
        }
}
}
