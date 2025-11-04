Console.WriteLine("Стоимость яблок, печенья, конфет за 1кг - 100 рублей.");
double price = 100;

Console.Write("Введите количество кг яблок: ");
double apple = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите количество кг печенья: ");
double cookie = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите количество кг конфет: ");
double candies = Convert.ToDouble(Console.ReadLine());

if (apple < 0 || cookie < 0 || candies < 0)
{
    Console.WriteLine("Ошибка");
}
else if (apple == 0 && cookie == 0 && candies == 0)
{
    Console.WriteLine("Вы ничего не взяли");
}
else
{
    double finp1 = price * apple;
    double finp2 = price * cookie;
    double finp3 = price * candies;
    double fin = finp1 + finp2 + finp3;
    Console.WriteLine($"Стоимость {fin}");
}
