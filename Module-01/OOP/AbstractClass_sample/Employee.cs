using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_sample
{
    class Employee : Person
    {
        // Lớp kế thừa phải override abstract method của lớp cha
        public override void DoThat()
        {
            Console.WriteLine("Employee do that.");
        }
    }
}
