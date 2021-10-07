using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable instantiatedObject = new Employee(); // new object of the interface's inheriting class
            {
                instantiatedObject.Quit(); // calling the Quit method on newly created interface object
            };
        }
    }
}
