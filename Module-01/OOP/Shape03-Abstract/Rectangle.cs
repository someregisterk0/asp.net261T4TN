using System;
using System.Collections.Generic;
using System.Text;

namespace Shape03_Abstract
{
    class Rectangle : Shape
    {
        double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return a * b;
        }

        public override double Perimeter()
        {
            return 2 * (a + b);
        }
    }
}
