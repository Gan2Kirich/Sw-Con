Console.Write("Введите радиус окружности ");
double R = Convert.ToDouble(Console.ReadLine());

double L =2 * Math.PI * R;

double S = Math.PI * (R * R);
Console.WriteLine("Длина окружности " + L + "\n");
Console.WriteLine("Площадь круга " + S);
