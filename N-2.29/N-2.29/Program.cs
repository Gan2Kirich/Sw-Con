Console.Write("Ввдети x 1-й точки: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввдети y 1-й точки: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдети x 2-й точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввдети y 2-й точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдети x 3-й точки: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввдети y 3-й точки: ");
double y3 = Convert.ToDouble(Console.ReadLine());


// AB
double x2x1 = x1 - x;
double y2y1 = y1 - y;
double d = Math.Sqrt(Math.Pow(x2x1,2)+ Math.Pow(y2y1, 2));

//BC
double x3x2 = x3 - x1;
double y3y2 = y3 - y1;
double d2 = Math.Sqrt(Math.Pow(x3x2, 2) + Math.Pow(y3y2, 2));

//AC
double x3x = x3 - x;
double y3y = y3 - y;
double d3 = Math.Sqrt(Math.Pow(x3x, 2) + Math.Pow(y3y, 2));

double P = d+d2+ d3;

double c1 = x * (y1 - y3);
double c2 = x1 * (y3 - y);
double c3 = x3 * (y - y1);
double f = c1 + c2 + c3;
double e = 1e-9;
if (Math.Abs(f) < e)
{
    Console.WriteLine("Ошибка");
}
else
{
    double S = 0.5 * Math.Abs(f);
    Console.WriteLine($"Периметр: {P}");
    Console.WriteLine($"Площадь: {S}");
}