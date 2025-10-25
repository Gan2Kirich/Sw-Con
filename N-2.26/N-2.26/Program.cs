using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_2._26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x 1-й точки ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y 1-й точки ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x 2-й точки ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y 2-й точки ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Pow((x2 - x1), 2);
            double b = Math.Pow((y2 - y1), 2);
            double fin = Math.Sqrt(a + b);
            Console.WriteLine($"Длина между точками {fin}");

        }
    }
}
