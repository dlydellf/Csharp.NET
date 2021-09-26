using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What number would you like to perform math operations on?");
                int number = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
