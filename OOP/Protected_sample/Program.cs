using System;

namespace Protected_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            p1.c = 10;
            
            Child c1 = new Child();
            c1.c = 999;
        }
    }
}
