using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите внешний радиус ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите внутриний радиус ");
            double r = Convert.ToDouble(Console.ReadLine());

            if (R <= r)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                double S = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));

                Console.WriteLine("Площадь кольца " + S);
            }
        }
    }
}
