using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            char[] a;
            char tmp;

            Console.WriteLine("Введите строку");
            s1 = Console.ReadLine();

            a = s1.ToCharArray();

            for(int i = 0; i<(s1.Length/2); i++)
            {
                tmp = a[i];
                a[i] = a[s1.Length-1-i];
                a[s1.Length - 1 - i] = tmp;
            }

            s2 = new String(a);

            Console.WriteLine(s2);
            Console.ReadKey();

        }
    }
}
