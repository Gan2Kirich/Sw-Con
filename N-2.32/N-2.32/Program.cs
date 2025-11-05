Console.Write("Введите стоимость монитора: ");
double monitor = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите стоимость системного блока: ");
double system_unit = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите стоимость клавиатуры: ");
double keyboard = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите стоимость мыши: ");
double mouse = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сколько компьтеров хотите купить: ");
double n = Convert.ToDouble(Console.ReadLine());


if (monitor < 0 || system_unit < 0 || keyboard < 0 || mouse < 0)
{
    Console.WriteLine("Ошибка");
}
else if (monitor == 0 && system_unit == 0 && keyboard == 0 && mouse == 0)
{
    Console.WriteLine("Всё бесплатно");
}
else
{
    double pricek = monitor + system_unit + keyboard + mouse;
    double price = pricek * 3;
    double pricen = pricek * n;
    Console.WriteLine($"Стоимость 3 компьтеров: {price}");
    Console.WriteLine($"Стоимость всех компьтеров: {pricen}");
}