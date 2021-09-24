using System;
using System.Collections.Generic;

namespace Exception_Handling__Console_App_Strings___Integers_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dividends = new List<int>{ 100, 200, 300, 400, 500 };
            Console.WriteLine("Please enter a number to divide each integer by: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            foreach (int dividend in dividends)
            {
                int quotient = dividend / divisor;
                Console.WriteLine($"{dividend} divided by {divisor} = {quotient}");
            }
            Console.ReadLine();
        }
    }
}
