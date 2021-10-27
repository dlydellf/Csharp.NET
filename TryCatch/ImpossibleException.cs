using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class ImpossibleException : Exception
    {
        public ImpossibleException()  // a standard CONSTRUCTOR
            : base() { }  // INHERITS from the base's ("Exception") CONSTRUCTOR
        public ImpossibleException(string message)  //"overloading" the above constrcutor's method, takes a <string> argument
            : base(message) { }  // inherits from the base ("Exception")'s CONSTRUCTOR, which ALSO has a constrcutor taking a <string> argument
    }
}
