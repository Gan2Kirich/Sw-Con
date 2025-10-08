Console.Write("Введите высоту: ");
double h = Convert.ToDouble(Console.ReadLine());

double R = 6350;

double d = Math.Sqrt(2*R*h+(h*h));

Console.WriteLine("Растояние до линии горизонта " + d);
