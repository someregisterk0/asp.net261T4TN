using System;

namespace Class_GetSet_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.SetFullName("danhnh");
            Console.WriteLine(e1.GetFullName());

            e1.Email = "danhnh@gmail.com";
            Console.WriteLine(e1.Email);
        }
    }
}
