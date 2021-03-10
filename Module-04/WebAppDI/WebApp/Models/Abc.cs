using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Abc : IAbc
    {
        public Abc()
        {
            Console.WriteLine("Abc constructor");
        }

        public Abc(string s)
        {
            Console.WriteLine($"Hello {s}");
        }

        public void Dispose()
        {
            Console.WriteLine("Abc Dispose.");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Abc Do Something.");
        }
    }
}
