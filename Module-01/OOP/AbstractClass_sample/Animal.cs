using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_sample
{
    class Animal
    {
        //field
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

        //method
        public void DoSomeThing()
        {
            Console.WriteLine("Animal do something");
        }

        // không thể tạo abstract method
        //public abstract void DoThat();
    }
}
