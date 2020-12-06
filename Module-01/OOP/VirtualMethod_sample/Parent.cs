using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethod_sample
{
    class Parent
    {
        public void DoSomeThing()
        {
            Console.WriteLine("Parent Do Something.");
        }

        public virtual void DoThat()
        {
            Console.WriteLine("Parent Do That.");
        }
    }
}
