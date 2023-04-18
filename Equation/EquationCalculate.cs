using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equation
{
    public class EquationCalculate
    {
        double a, b, c;
        public EquationCalculate(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Calculate_Delta()
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine(delta);
            return delta;
        }
    }
}
