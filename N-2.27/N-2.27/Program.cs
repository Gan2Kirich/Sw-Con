Console.Write("Введите 1-e основание ");
double a = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите 2-e основание ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите высоту ");
double h = Convert.ToDouble(Console.ReadLine());

if (b > a)
{
    double t = a;
    a = b;
    b = t;
}
    double x = (a - b) / 2;
    double c = Math.Sqrt(Math.Pow(h,2)+Math.Pow(x,2));
    double P = a + b + 2 * c;
    Console.WriteLine($"Периметр равен {P}");

