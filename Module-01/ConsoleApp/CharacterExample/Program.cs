using System;

namespace CharacterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Nhap ky tu: ");
            ch = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine(ch);

            Console.WriteLine(ch - 'A');
        }
    }
}
