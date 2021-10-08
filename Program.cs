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
            double res = (1 / 13) + Math.Log(Math.Abs((X + 2) / 3)) + X + 3 + Math.Min(X, 1) + 2 * Math.Cos(X / 3) + Math.Pow(X, X);
            return res;

        }
    }
}
//16. f(x) = 1/13 + ln(|(x+2)/3|) + x+3 + min(x, 1) + 2cos(x/3) + x^x