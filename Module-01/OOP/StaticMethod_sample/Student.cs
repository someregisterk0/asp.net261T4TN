using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod_sample
{
    class Student
    {
        // Fields
        // non-static field
        string name;
        // static field
        static int total;

        // Methods
        // non-static method
        public void DoSomeThing()
        {
            name = "Jack";
            total = 99;
            
            Console.WriteLine("Non static method DoSomeThing.");
        }

        // static method
        public static void DoThat()
        {
            // không thể trực tiếp gọi non-static field và non-static method từ static method
            //name = "Peter";
            //DoSomeThing();
            // Phải gọi thông qua một instance object
            Student s = new Student();
            s.name = "Peter";
            s.DoSomeThing();
            total = 100;
            Console.WriteLine("Static method DoThat.");
        }
    }
}
