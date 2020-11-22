using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp01
{
    class Ellipe
    {
        double a, b;

        public Ellipe(double x, double y)
        {
            a = x;
            b = y;
        }

        public double Perimeter()
        {
            return Math.PI * (a + b);
        }

        public double Area()
        {
            return Math.PI * a * b;
        }
    }
}
