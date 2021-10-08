using System;

namespace Exercise2
{
    class Program
    {
        static double x;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            x = Double.Parse(Console.ReadLine());
            double y = F(x);
            Console.WriteLine("f({1})={0}", y, x);
            Console.Read();

        }
        static double F(double X)
        {
            double res = (1.0 / 13.0) + Math.Log(Math.Abs((X + 2.0) / 3.0)) + X + 3.0 + Math.Min(X, 1.0) + 2.0 * Math.Cos(X / 3.0) + Math.Pow(X, X);
            return res;

        }
    }
}
//16. f(x) = 1/13 + ln(|(x+2)/3|) + x+3 + min(x, 1) + 2cos(x/3) + x^x