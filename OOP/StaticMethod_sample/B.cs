using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod_sample
{
    class B : A
    {
        // Override non-static mehtod
        public override void DoSomeThing()
        {
            Console.WriteLine("B do some thing.");
        }


        // Không thể override static method từ class cha
        //public override void DoThat()
        //{

        //}
    }
}
