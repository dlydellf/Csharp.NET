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
        string firstName { get; set; }
        string lastName { get; set; }

        // Required method:
        public virtual void SayName() // "virtual" == inheritable & implementable (via overriding)
        {

        }
    }
}
