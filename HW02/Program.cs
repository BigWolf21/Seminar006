// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetDoubleNumber(string text)
{
  double value = 0;
  bool flag = false;
  while (!flag)
  {
    Console.Write(text);
    flag = double.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

double b1 = GetDoubleNumber("Введите b1: ");
double k1 = GetDoubleNumber("Введите k1: ");
double b2 = GetDoubleNumber("Введите b2: ");
double k2 = GetDoubleNumber("Введите k2: ");
 
 
double x = Math.Round(-(b1 - b2) / (k1 - k2), 3);
double y = Math.Round(k1 * x + b1, 3);

 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
