Console.Write("Введите растояние между городами: ");
int  distance = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость 1 автомобиля: ");
int V1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость 2 автомобиля: ");
int V2 = Convert.ToInt32(Console.ReadLine());

if (distance <= 0 || V1 <= 0 || V2 <= 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    double t = distance /(double)(V1 + V2);
    Console.WriteLine($"Они встретяться через: {t}");
}
