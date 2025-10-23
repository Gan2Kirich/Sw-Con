Console.Write("Введите длину ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите ширину ");
double b = Convert.ToDouble(Console.ReadLine());

double p = 2*(a + b);
double d = Math.Sqrt(Math.Pow(a,2)+ Math.Pow(b, 2));
Console.WriteLine($"Длина {p}");
Console.WriteLine($"Длина {d}");