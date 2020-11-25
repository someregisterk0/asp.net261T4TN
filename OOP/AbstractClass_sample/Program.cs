using System;

namespace AbstractClass_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Không thể khởi tạo Abstract class
            //Person p1 = new Person();

            Animal a1 = new Animal();

            Employee e1 = new Employee();
            e1.DoThat();

            Person p1 = new Employee();
            p1.DoThat();
        }
    }
}
