using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b ");
            double b = Convert.ToDouble(Console.ReadLine());

            double d = Math.Pow(a, 2);
            double n = Math.Pow(b, 2);

            double c = d + n;

            double fin = Math.Sqrt(c);
            Console.WriteLine("Гипотенуза равна " + fin);
        }
    }
}
