Console.Write("Введите длину ребра куба ");
int a = Convert.ToInt32(Console.ReadLine());

int v = a * a * a;

int sb = 4 * a * a;

Console.WriteLine("Обьем куба " + v + "\n");
Console.WriteLine("Площадь боковой поверхности " + sb );