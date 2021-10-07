using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, m, A, NW, Cl, W, l, S;
            H = double.Parse(Console.ReadLine());
            m = double.Parse(Console.ReadLine());
            A = double.Parse(Console.ReadLine());
            l= double.Parse(Console.ReadLine());         

            NW = H - 0.09;
            Cl=(9.99*m)+(6.25*H)-(4.92 * A);
            W = 0.03 * A;
            S = l / 2 + m * H;

            Console.WriteLine($"Рост:{H}");
            Console.WriteLine($"Вес:{m}");
            Console.WriteLine($"Возраст:{A}");
            Console.WriteLine($"Длина крыльев:{l}");
            Console.WriteLine($"Нормальный Вес:{NW}");
            Console.WriteLine($"Количество калорий в день:{Cl}");
            Console.WriteLine($"Количество воды в день:{W}");
            Console.WriteLine($"Скорость:{S}");
        }
    }
}
//NW=H-0,09; C=9,99*m+6,25*H-4,92*A; W=0,03*A; S=l/2+m*H//