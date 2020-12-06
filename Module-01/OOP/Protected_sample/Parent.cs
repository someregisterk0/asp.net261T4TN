using System;
using System.Collections.Generic;
using System.Text;

namespace Protected_sample
{
    class Parent
    {
        // private (default)
        int a;
        protected int b;
        public int c;

        public void DoSomeThing()
        {
            a = 7;
            b = 8;
            c = 9;
        }
    }
}
