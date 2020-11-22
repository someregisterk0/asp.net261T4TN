using System;
using System.Collections.Generic;
using System.Text;

namespace KeThua_sample
{
    class Person
    {
        // fields
        private string fullName;
        private string email;
        private int age;

        // method
        public void Input()
        {
            Console.Write("Name: ");
            fullName = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
        }

        public void OutPut()
        {
            Console.WriteLine($"{fullName}");
            Console.WriteLine($"{email}");
        }

        // property
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
