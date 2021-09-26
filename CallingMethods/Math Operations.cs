using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Math_Operations
    {
        // "public" == method is available throughout program
        // "static" == no object was created before calling this method
        // "int" == 1st) returns dataType <int>; 2nd) takes parameter of dataType <int>, which is named "number"
        public static int Adding(int number) 
        {
            int sum = number + number; // this method's main calculation; result assigned to <int> variable "sum"
            Console.WriteLine($"\n1) {number} + {number} = {sum}");
            return sum;
        }

        public static int Multiply(int number)
        {
            int product = (number * number); // this method's main calculation; result assigned to <int> variable "product"
            Console.WriteLine($"2) {number} x {number} = {product}");
            return product;
        }
        public static int Divide(int number)
        {
            int quotient = number / 2;
            Console.WriteLine($"3) {number} divided by 2 = {quotient}");
            return quotient;
        }
    }
}
