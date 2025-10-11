using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_2._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите основание а ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите основание b ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту h ");
            double h = Convert.ToDouble(Console.ReadLine());

            if (a <= b)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                double x = (a - b) / 2;

                double c = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(x, 2));

                double P = a + b + 2 * c;
                Console.WriteLine("Периметр " + P);
            }
        }
    }
}
