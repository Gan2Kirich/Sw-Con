// раздел а
Console.Write("Введите число e ");
double e = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число f ");
double f = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число g ");
double g = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число h ");
double h = Convert.ToDouble(Console.ReadLine());
if (f == 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    double s = Math.Abs(e - (3 / f));
    double a = Math.Sqrt(Math.Pow(s, 3) + g);
    Console.WriteLine("Результат а " + a);
}
// раздел b
double cos = Math.Cos(h);
double tcos = Math.Pow(cos, 2);

double b = Math.Sin(e) + tcos;
Console.WriteLine("Результат b " + b);
// раздел c
double gg = 33 * g;
double x = (e * f) - 3;
double c = gg / x;
Console.WriteLine("Результат с " + c);


