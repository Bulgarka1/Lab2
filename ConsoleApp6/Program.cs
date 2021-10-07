using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, s, p;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            s = (a + b) / 2 * Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a + b, 2));
            d = Math.Sqrt(Math.Pow(c, 2) + a * b);
            p = ((a + b + c) / 2);
            Console.WriteLine($"Сторона:{a}");
            Console.WriteLine($"Сторона:{b}");
            Console.WriteLine($"Сторона:{c}");
            Console.WriteLine($"Площадь:{s}");
            Console.WriteLine($"Периметр:{p}");
            Console.WriteLine($"Диагональ:{d}");
        }
    }
}
//16. Даны стороны равнобедренной трапецией, найти площадь, периметр и длину диагоналей.//