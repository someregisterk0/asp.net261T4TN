using System;

namespace Interface_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface không thể khởi tạo
            //IShape shape = new IShape();

            Square s1 = new Square();
            s1.DoThat();
            s1.DoSomeThing();
            IShape is1 = new Square();
            is1.DoThat();
        }
    }
}
