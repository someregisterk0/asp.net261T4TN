using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod_sample
{
    class A
    {
        // Non-static có thể dùng virtual, abstract
        // Và có thể override bởi class con
        public virtual void DoSomeThing()
        {
            Console.WriteLine("A do some thing");
        }

        // Static method không thể dùng từ khóa virtual, abstract
        // Và không thể override bởi class con
        public /*virtual*/ static void DoThat()
        {
            Console.WriteLine("A do that.");
        }
    }
}
