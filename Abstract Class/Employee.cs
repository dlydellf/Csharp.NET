using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee : Person
    {
        public override void SayName() // this virtual method is being overridden
        {
            base.SayName();
        }
    }
}
