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
            Console.Write("Ввдетие катет а ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввдетие катет b ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            double P = a + b + c;
            Console.WriteLine("Периметр равен " + P);
        }
    }
}
