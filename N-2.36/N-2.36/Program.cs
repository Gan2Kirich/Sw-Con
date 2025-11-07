Console.Write("Введите температуру(по цельсию) ");
double c = Convert.ToDouble(Console.ReadLine());

double tf = c * 1.8 + 32;
double tk = c + 273.15;
Console.WriteLine($"Температура по фаренгету {tf}");
Console.WriteLine($"Температура в кельвинах {tk}");
