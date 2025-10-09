Console.Write("Введите массу тела ");
double m = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите обьем тела ");
double v = Convert.ToDouble(Console.ReadLine());

double p = m / v;

Console.WriteLine("Плотность материала этого тела " + p);
