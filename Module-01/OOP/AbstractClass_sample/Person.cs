using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_sample
{
    abstract class Person
    {
        //fields
        string name;
        
        //properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Methods
        public void DoSomeThing()
        {
            Console.WriteLine("Abstract do something.");
        }

        // Abstract method, không cần cài đặt
        public abstract void DoThat();
    }
}
