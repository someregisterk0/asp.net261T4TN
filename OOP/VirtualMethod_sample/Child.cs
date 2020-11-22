using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethod_sample
{
    class Child : Parent
    {
        public void DoSomeThing()
        {
            Console.WriteLine("Child (new) Do Something.");
        }

        public override void DoThat()
        {
            Console.WriteLine("Child virtual (override) Do That");
        }
    }
}
