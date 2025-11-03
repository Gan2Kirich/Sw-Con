Console.Write("Ввдети x  точки A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввдети y точки A: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдети x точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввдети y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдети x точки C: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввдети y точки C: ");
double y3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдети x точки D: ");
double x4 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввдети y точки D: ");
double y4 = Convert.ToDouble(Console.ReadLine());

// ABC

double bracket = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1-y2);
double S1 = 0.5 * Math.Abs(bracket);

// ADC
double bracket2 = x1 * (y4 - y3) + x4 * (y3 - y1) + x3 * (y1 - y4);
double S2 = 0.5 * Math.Abs(bracket2);

double Sf = S1 + S2;
Console.WriteLine($"Результат: {Sf}");