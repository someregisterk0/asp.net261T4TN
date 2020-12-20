using System;

namespace Idisporable_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Tinh();
            Console.WriteLine($"a = {a}");

            Student s1 = new Student();
            s1.DoSomeThing();

            Employee e1 = new Employee();
            e1.DoThat("e1");
            e1.Dispose();

            using (Employee e2 = new Employee())
            {
                e2.DoThat("e2");
            }

            Console.WriteLine("continue");
        }

        static int Tinh()
        {
            using (Employee e1 = new Employee())
            {
                e1.DoThat("e1");
                return 55;
                //e1.DoThat("ádfdsf");
            }
        }
    }
}
