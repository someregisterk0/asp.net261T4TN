using System;
using System.Collections.Generic;
using System.Text;

namespace KeThua_sample
{
    class Employee : Person
    {
        private string salary;

        public void InputSalary()
        {
            Console.Write("Salary: ");
            salary = Console.ReadLine();
        }

        public void OutputSalary()
        {
            Console.WriteLine($"{salary}");
        }
    }
}
