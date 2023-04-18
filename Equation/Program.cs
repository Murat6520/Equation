using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A quadratic equation in math is a second-degree equation of the form ax^2 + bx + c = 0. Here a and b are the coefficients, c is the constant term, and x is the variable. Since the variable x is of the second degree, there are two roots or answers for this quadratic equation.Discriminant: D = b^2-4ac*/
            double coefficients_A, coefficients_B, constant_C;
            Console.Write("Coefficients a=");
            coefficients_A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Coefficients b=");
            coefficients_B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Constant c=");
            constant_C = Convert.ToDouble(Console.ReadLine());
            EquationCalculate calculate = new EquationCalculate(coefficients_A, coefficients_B, constant_C);
            double result=calculate.Calculate_Delta();
            if (result>=0)
                Console.WriteLine("1 and 2 real roots.");
            else
                Console.WriteLine("No real roots.");
            Console.ReadLine();
        }
        
    }
}
