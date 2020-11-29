using System;

namespace StaticMethod_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            // call non-static method (object)
            s1.DoSomeThing();

            // call static method (class)
            Student.DoThat();

            A a1 = new A();
            a1.DoSomeThing();
            A.DoThat();

            A a2 = new B();
            a2.DoSomeThing();
        }
    }
}
