using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_2._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-е число ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 2-е число ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;
            double rath = a - b;
            double pro = a * b;

            Console.WriteLine("Сумма " + sum);
            Console.WriteLine("Разность " + rath);
            Console.WriteLine("Произведение " + pro);

            if (b == 0)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                double chas = a / b;
                Console.WriteLine("Деление " + chas);
            }
        }
    }
}
