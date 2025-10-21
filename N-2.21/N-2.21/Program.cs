Console.Write("введиет е ");
double e = Convert.ToDouble(Console.ReadLine());

Console.Write("введиет f ");
double f = Convert.ToDouble(Console.ReadLine());

Console.Write("введиет g ");
double g = Convert.ToDouble(Console.ReadLine());

Console.Write("введиет h ");
double h = Convert.ToDouble(Console.ReadLine());


// пример a 
double numerator = e + (f / 2);
double a = numerator / 3;
// пример b
double b = (Math.Abs(Math.Pow(h, 2) - g));
// пример c 
double braket = g - h; 
double ex = Math.Sqrt(Math.Pow(braket,2)-3* Math.Sin(e));
if (ex >= 0)
{
    double c = Math.Sqrt(ex);
    Console.WriteLine($"Результат a = {a}");
    Console.WriteLine($"Результат b = {b}");
    Console.WriteLine($"Результат c = {c}");
}
else
{
    Console.WriteLine("Результат a = " + a);
    Console.WriteLine("Результат b = " + b);
    Console.WriteLine("Ошибка!");
}