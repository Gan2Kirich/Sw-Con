Console.Write("Введите чмсло: ");
int n;

 if (int.TryParse(Console.ReadLine(), out n))
{
    int nex = n + 1;
    int pox = n - 1;

    Console.WriteLine("Следующее за  числом " + n + " число - " + nex);
    Console.WriteLine("Для числа " + n + " предыдущее число - " + pox);
}
 else
{
    Console.WriteLine("Ошибка: Введенное значение не является целым числом.");
}
