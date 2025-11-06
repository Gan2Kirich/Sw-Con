Console.Write("Ввдетие скорость 1 автомобиля(Больше чем 2): ");
double V1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдетие скорость  автомобиля: ");
double V2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдетие на сколько км 1 автомобиль опередил 2: ");
double S = Convert.ToDouble(Console.ReadLine());

if (V1 <= 0 || V2 <= 0 || S <= 0)
{
    Console.WriteLine("Ошибка");
}
else if (V1 <= V2)
{
    Console.WriteLine("Ошибка");
}
else
{
    double V = V1 - V2;
    double S1 = 0.5 * V;
    double fin = S + S1;
    Console.WriteLine($"Расстояние через 30 мин: {fin}");
}