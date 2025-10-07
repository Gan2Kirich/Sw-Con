// раздел a
Console.Write("Введите число a: ");
double a = Convert.ToDouble(Console.ReadLine());
double y = 2 * a + Math.Sin(Math.Abs(3*a));
double z = y / 3.56;
double c = Math.Sqrt(z);

Console.WriteLine("Результат функции: " + c);


// раздел б

Console.Write("Введите число x: ");
double x = Convert.ToDouble(Console.ReadLine());

double num = 3.2 + Math.Sqrt(1 + x);
double fd = num / Math.Abs(5*x);
double fin = Math.Sin(fd);
Console.WriteLine("Результат функции: " + fin);
