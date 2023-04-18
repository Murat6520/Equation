using System;
using Equation;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        EquationCalculate test;
        public UnitTest1()
        {
            //test = new EquationCalculate(1, -4, -2);
        }

        [Theory]
        [InlineData(1,-4,-2, 24)]
        [InlineData(1, -4, -2, 20)]
        public void TestResult(double theory_a, double theory_b, double theory_c, double expected)
        {
            test = new EquationCalculate(theory_a, theory_b, theory_c);
            double actual = test.Calculate_Delta();
            Assert.Equal(expected, actual);
        }
    }
}
