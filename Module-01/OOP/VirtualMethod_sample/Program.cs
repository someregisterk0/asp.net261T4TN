using System;

namespace VirtualMethod_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            p1.DoSomeThing();
            p1.DoThat();

            Child c1 = new Child();
            c1.DoSomeThing();
            c1.DoThat();

            Parent p2 = new Child();
            p2.DoSomeThing();
            // Polymorphism, Đa xạ
            p2.DoThat();
        }
    }
}
