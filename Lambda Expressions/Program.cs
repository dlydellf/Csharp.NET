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
            // creates new <List> (dataType == "<Employee>"), named "employees":
            List<Employee> employees = new List<Employee>
            {
                // Adds 10 new employees to newly-created "employees" <List>:
                new Employee { Id = 01, FName = "Joe", LName = "Adams" },
                new Employee { Id = 02, FName = "Joe", LName = "Biden" },
                new Employee { Id = 03, FName = "Douglas", LName = "Foreman" },
                new Employee { Id = 04, FName = "Employee", LName = "Four" },
                new Employee { Id = 05, FName = "Employee", LName = "Five" },
                new Employee { Id = 06, FName = "Employee", LName = "Six" },
                new Employee { Id = 07, FName = "Employee", LName = "Seven" },
                new Employee { Id = 08, FName = "Employee", LName = "Eight" },
                new Employee { Id = 09, FName = "Employee", LName = "Nine" },
                new Employee { Id = 10, FName = "Employee", LName = "Ten" },
            };
        }
    }
}
