Console.Write("Введите 1-е число ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите 2-е число ");
double b = Convert.ToDouble(Console.ReadLine());

double arm = (a + b)/2;
double geom = Math.Sqrt(Math.Abs(a)*Math.Abs(b));
Console.WriteLine($"Арифмитическое {arm}");
Console.WriteLine($"Геометричекое {geom}" );