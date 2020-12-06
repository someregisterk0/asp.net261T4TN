using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_sample
{
    class Square : IShape, ISomeThing
    {
        // class con có thể kế thừa từ nhiều Interface

        // class kế thừa từ Interface phải override method abstract
        // không cần từ khóa override
        public void DoThat()
        {
            Console.WriteLine("Sqare do that.");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Sqare do some thing.");
        }
    }
}
