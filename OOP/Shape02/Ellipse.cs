using System;
using System.Collections.Generic;
using System.Text;

namespace Shape02
{
    class Ellipse : Shape
    {
        double a, b;
        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Perimeter()
        {
            return Math.PI * (a + b);
        }

        public override double Area()
        {
            return Math.PI * a * b;
        }
    }
}
