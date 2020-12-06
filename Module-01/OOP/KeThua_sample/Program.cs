using System;

namespace KeThua_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Input();
            p1.OutPut();
            p1.Age = 19;
            Console.WriteLine($"age = {p1.Age}");

            Employee e1 = new Employee();
            e1.Input();
            e1.OutPut();
            e1.InputSalary();
            e1.OutputSalary();
        }
    }
}
