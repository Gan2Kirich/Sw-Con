Console.Write("Ведите большее основание: ");
double a = Convert.ToDouble(Console.ReadLine());


Console.Write("Ведите меньшее основание: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Ведите угол: ");
double alfa = Convert.ToDouble(Console.ReadLine());

if (a <= 0 || b <= 0)
{
    Console.WriteLine("Ошибка");
}
else if (alfa <= 0 || alfa >= 180)
{
    Console.WriteLine("Ошибка");
}
else
{
    if (b > a)
    {
        double t = a;
        a = b;
        b = t;
    }
    double alfag = alfa * (Math.PI / 180.0);
    double x = (a - b) / 2;
    double h = x * Math.Tan(alfag);
    double H = Math.Abs(h);
    double S = ((a + b) / 2) * H;
    Console.WriteLine($"Площадь: {S}");
}

