﻿using System;
/* Commenting-out these unused NameSpaces:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace MethodClass_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatedClass instantiatedClass = new CreatedClass(); // instantiates an instance of the class
            instantiatedClass.createdMethod(10, 20);
        }
    }
}
