// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = Read("k1");
double b1 = Read("b1");
double k2 = Read("k2");
double b2 = Read("b2");

double Read(string arg)
{
  System.Console.WriteLine($"Введите {arg}: ");
  double n = double.Parse(System.Console.ReadLine());
  return n;
}

void Dot(double k1,double b1,double k2,double b2)
{
  if (k1 == k2)
  {
    System.Console.WriteLine("Прямые параллельны");
  }
  else
  {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    System.Console.WriteLine($"Точка пересечения: ({x}, {y})");
  }
}

Dot(k1, b1, k2, b2);