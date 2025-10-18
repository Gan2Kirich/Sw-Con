// Раздел x
Console.Write("Введите число а (а не равно 0) ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b (b не равно 0) ");
double b = Convert.ToDouble(Console.ReadLine());

if (a == 0 || b == 0)
{
    Console.WriteLine("Ошибка");
}
else if ( b < 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    double v = 2 / (Math.Pow(a, 2) + 25);
    double c = v + b;

    double g = (a + b) / 2;
    double h = Math.Sqrt(b) + (a+b)/2;

    double fin = c / h;
    Console.WriteLine("Результат x " + fin);
}
// Раздел y
Console.Write("Введите число а  ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b ");
double B = Convert.ToDouble(Console.ReadLine());

double n = Math.Abs(A) + 2 * Math.Sin(B);
double m = 5.5 * A;
if (m == 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    double FIN = n/ m;
    Console.WriteLine("Результат y " + FIN);
}