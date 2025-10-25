using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_2._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину ");
            int b = Convert.ToInt32(Console.ReadLine());

            int V = a * b * h;
            int S = 2 * (a + b) * h;
            Console.WriteLine($"Обьем {V}");
            Console.WriteLine($"Площадь боковой поверхности {S}");
        }
    }
}
