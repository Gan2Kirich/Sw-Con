// раздел a 
Console.Write("Введите число x ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число y ");
double y = Convert.ToDouble(Console.ReadLine());

double z = (2 * Math.Pow(x, 3)) - (3.44 * x * y) + (2.3 *Math.Pow(x,2))- (7.1 * y) + 2;

Console.WriteLine("Рузультат вычислений " + z);

// рахдел б
Console.Write("Введите число a ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b ");
double b = Convert.ToDouble(Console.ReadLine());

double n = a + b;

double X = (3.14*Math.Pow(n,3)) + (2.75*Math.Pow(b,2)) - (12.7*a) - 4.1;

Console.WriteLine("Рузультат вычислений " + X);