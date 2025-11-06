Console.Write("Введите возраст Тани: ");
int T = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите возраст Мити: ");
int M = Convert.ToInt32(Console.ReadLine());

if (M <= 0 || T <= 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    double r = (double)(M + T) / 2;
    double Mv = M - r;
    double Tv = T - r;

    if (Tv < 0)
    {
        double fT = Math.Abs(Tv);
        Console.WriteLine($"Средний возраст: {r}");
        Console.WriteLine($"Митя старше на : {Mv}");
        Console.WriteLine($"Таня младше на: {fT}");
    }
    else if (Mv < 0)
    {
        double fM = Math.Abs(Mv);
        Console.WriteLine($"Средний возраст: {r}");
        Console.WriteLine($"Митя младше на : {fM}");
        Console.WriteLine($"Таня старше на: {Tv}");
    }
}
