using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            string xstr = Console.ReadLine();
            Console.WriteLine("Введите y:");
            string ystr = Console.ReadLine();
            Console.WriteLine("Введите z:");
            string zstr = Console.ReadLine();

            double x = Convert.ToDouble(xstr);          
            double y = Convert.ToDouble(ystr);
            double z = Convert.ToDouble(zstr);

            double f;
            f = 1.0 / 13.0 + Math.Log(Math.Abs((y + 2.0) / 3.0)) + z + 3.0 + Math.Min(x, 1.0);
            Console.WriteLine(f);
        }
    }
}
//16. f(x, y, z) = 1/13 + ln(|(y+2)/3|) + z+3 + min(x, 1)//