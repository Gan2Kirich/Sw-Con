Console.Write("Ведите массу в кг: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    int fin = a / 100;
    Console.WriteLine($"Целое число в центнерах: {fin}");
}