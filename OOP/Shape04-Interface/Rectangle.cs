using System;
using System.Collections.Generic;
using System.Text;

namespace Shape04_Interface
{
    class Rectangle : IShape
    {
        double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Area()
        {
            return a * b;
        }

        public double Perimeter()
        {
            return 2 * (a + b);
        }
    }
}
