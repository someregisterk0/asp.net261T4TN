using System;
using System.Collections.Generic;
using System.Text;

namespace Idisporable_example
{
    class Employee : IDisposable
    {
        public void DoThat(string name)
        {
            Console.WriteLine($"Employee {name} do that.");
        }

        public void Dispose()
        {
            Console.WriteLine("Employee dispose.");
        }
    }
}
