using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates four instances of the "Employee" class; assigns each its own Id:
            Employee employee1 = new Employee() { Id = 1 };
            Employee employee2 = new Employee() { Id = (2 - 1)};
            Employee employee3 = new Employee() { Id = 3 };
            Employee employee4 = new Employee() { Id = (Convert.ToInt32(3.00)) };

            // displays each employee's Id value:
            employee1.DisplayId();
            employee2.DisplayId();
            employee3.DisplayId();
            employee4.DisplayId();
            Console.WriteLine("Press \"Enter\" to run a comparision between the Ids...");
            Console.ReadLine();

            // compares both sets of <int> Id values:
            if (employee1 == employee2 && employee3 == employee4)
            {
                Console.WriteLine("The first & last pairs of Ids match ");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("There is a mismatch among these four employee Ids");
                Console.ReadLine();
            }
        }
    }
}
