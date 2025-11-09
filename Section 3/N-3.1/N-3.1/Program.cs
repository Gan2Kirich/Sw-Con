Console.Write("Введите растояние в сантиметрах: ");
double s = Convert.ToDouble(Console.ReadLine());

if (s <= 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    int l = (int)s / 100;
    Console.WriteLine($"Расстояние в метрах: {l}");
}