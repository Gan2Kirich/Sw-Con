Console.Write("Введите число а(не может быть рано 0) ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b ");
double b = Convert.ToDouble(Console.ReadLine());

if (a == 0)
{
    if (b == 0)
    {
        Console.WriteLine("Множество решений");

    }
    else
    {
        Console.WriteLine("Нет решений");
    }
}
else
{
    double c = -b / a;
    Console.WriteLine("Ответ " + c);

}