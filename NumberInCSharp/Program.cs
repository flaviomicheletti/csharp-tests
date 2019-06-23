using System;
using Xunit;

namespace NumberInCSharp
{
    public class Program
    {

        [Fact]
        static void WorkingWithIntegersTest()
        {
            int a = 18;
            int b = 6;
            int c = 0;
            
            c = a + b;
            Assert.Equal(24, c);

            c = a - b;
            Assert.Equal(12, c);  

            c = a * b;
            Assert.Equal(108, c);  

            c = a / b;
            Assert.Equal(3, c);  

        }

        [Fact]
        static void OrderPrecedenceTest()
        {   
            int a = 5;
            int b = 4;
            int c = 2;
 
            Assert.Equal(13, a + b * c);  
            Assert.Equal(18, (a  + b) * c);  

            // Talvez você tenha observado um comportamento interessante com relação aos números inteiros. 
            // A divisão de inteiros sempre produz um resultado inteiro, mesmo quando você espera que o 
            // resultado inclua uma parte decimal ou fracionária.
            Assert.Equal(25, (a + b) - 6 * c + (12 * 4) / 3 + 12);  

            int e = 7;
            int f = 4;
            int g = 3;
            Assert.Equal(3, (e  + f) / g);  
       }

        [Fact]
        static void ModuloTest()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a  + b) / c;
            int e = (a + b) % c;
            Assert.Equal(3, (a + b) / c); // quotient
            Assert.Equal(2, (a + b) % c); // remainder
        }

        [Fact]
        static void IntMinimumMaximumLimitsTest()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Assert.Equal(2147483647, max);
            Assert.Equal(-2147483648, min);
        }

        [Fact]
        static void DoublePrecisionTest()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            Assert.Equal(4.5, (a  + b) / c);

            a = 19;
            b = 23;
            c = 8;
            Assert.Equal(5.25, (a  + b) / c);

        }

        static void DoubleMinimumMaximumLimits()
        {
            double max = double.MaxValue;
            double min = double.MinValue;
            Assert.Equal("-1.79769313486232E+308", min.ToString());
            Assert.Equal("1.79769313486232E+308", max.ToString());

            double third = 1.0 / 3.0;
            Assert.Equal(0.333333333333333, third);
        }

    }
}
