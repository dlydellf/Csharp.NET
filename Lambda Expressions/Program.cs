using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();
            employees.Add("01 - Joe Adams");
            employees.Add("02 - Joe Biden");
            employees.Add("03 - Douglas Foreman");
            employees.Add("04 - Employee Four");
            employees.Add("05 - Employee Five");
            employees.Add("06 - Employee Six");
            employees.Add("07 - Employee Seven");
            employees.Add("08 - Employee Eight");
            employees.Add("09 - Employee Nine");
            employees.Add("10 - Employee Ten");

            Console.WriteLine(employees.Count);
            Console.ReadLine();

        }
    }
}
