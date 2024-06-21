using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Program
    {
        public static double Addx2(double a, double b, double c, double d)
        {
            Calculator c1 = new Calculator();
            Calculator c2 = new Calculator();
            return c1.Add(a, b) + c2.Add(c, d);
        }

        public static double Subtractx2(double a, double b, double c, double d)
        {
            Calculator c1 = new Calculator();
            Calculator c2 = new Calculator();
            return c1.Subtract(a, b) - c2.Subtract(c, d);
        }

        public static double Multiplyx2(double a, double b, double c, double d)
        {
            Calculator c1 = new Calculator();
            Calculator c2 = new Calculator();
            return c1.Multiply(a, b) * c2.Multiply(c, d);
        }

        public static double Dividex2(double a, double b, double c, double d)
        {
            Calculator c1 = new Calculator();
            Calculator c2 = new Calculator();
            return c1.Divide(a, b) / c2.Divide(c, d);
        }

        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Calculator c2 = new Calculator();

            Console.WriteLine(c1.Add(10, 20));
            Console.WriteLine(c1.Subtract(20, 10));
            Console.WriteLine(c1.Multiply(10, 20));
            Console.WriteLine(c1.Divide(20, 10));

            Console.WriteLine(c2.Add(10, 20));
            Console.WriteLine(c2.Subtract(20, 10));
            Console.WriteLine(c2.Multiply(10, 20));
            Console.WriteLine(c2.Divide(20, 10));

            double addx2Result = Addx2(1.2, 2.3, 3.4, 4.5);
            double subtractx2Result = Subtractx2(1.2, 2.3, 3.4, 4.5);
            double multiplyx2Result = Multiplyx2(1.2, 2.3, 3.4, 4.5);
            double dividex2Result = Dividex2(1.2, 2.3, 3.4, 4.5);
        }
    }
}
