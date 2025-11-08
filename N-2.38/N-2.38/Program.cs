Console.Write("Введите 1 число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите 2 число: ");
double b = Convert.ToDouble(Console.ReadLine());

double sum = a + b;
double pro = a - b;
double um = a * b;
double del = a / b;
double chas = (a + b) / 2;
Console.WriteLine($"Результаты\n1) {a} + {b} = {sum}; 2) {a} - {b} = {pro}; 3) {a} * {b} = {um}; 4) {a} / {b} = {del}; 5) ({a} + {b}) / 2 = {chas}");;

double sum1 = b + a;
double pro1 = b - a;
double um1 = b * a;
double del1 = b / a;
double chas1 = (a + b) / 2;
Console.WriteLine($"Результаты\n6) {b} + {a} = {sum1}; 7) {b} - {a} = {pro1}; 8) {b} * {a} = {um1}; 9) {b} / {a} = {del1}; 10) ({a} + {b}) / 2 = {chas1}");