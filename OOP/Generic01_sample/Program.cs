using System;

namespace Generic01_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayList<string> strList = new ArrayList<string>();
            strList.Add("Jack");
            strList.Add("Peter");
            strList.PrintList();

            ArrayList<int> intList = new ArrayList<int>();
            intList.Add(3);
            intList.Add(7);
            intList.PrintList();
        }
    }
}
