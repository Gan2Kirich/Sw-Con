using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_2._18
{
    class Program
    {
        static void Main(string[] args)
        {
            // пример z
            Console.Write("Введите число x ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число y ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                double c = (2 + y) / Math.Pow(x, 2);
                double a = x + c;

                double d = 1 / (Math.Sqrt(Math.Pow(x, 2) + 10));
                double b = y + d;

                double z = a / b;
                Console.WriteLine("Результат " + z);
            }
            // пример  q
            Console.Write("Введите число x ");
            double X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число y ");
            double Y = Convert.ToDouble(Console.ReadLine());
            double q = 7.25 * Math.Sin(X) - Math.Abs(Y);
            Console.WriteLine("Результат" + q);
        }
    }
}
