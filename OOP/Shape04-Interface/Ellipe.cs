using System;
using System.Collections.Generic;
using System.Text;

namespace Shape04_Interface
{
    class Ellipe : IShape
    {
        double a, b;
        public Ellipe(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Area()
        {
            return Math.PI * a * b;
        }

        public double Perimeter()
        {
            return Math.PI * (a + b);
        }
    }
}
