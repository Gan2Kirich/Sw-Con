Console.Write("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());

double c = (a + b) / 2;

double d = Math.Sqrt(a * b);

Console.Write("Среднее арифмитеческое " + c);
Console.Write("Среднее геометрическое " + d);