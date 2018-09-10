using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulaGerona
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, s;
            Console.WriteLine("Введите сторону a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону c");
            c = Convert.ToDouble(Console.ReadLine());

            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("По формуле Герона площадь треугольника S = {0}", s);
        }
    }
}
