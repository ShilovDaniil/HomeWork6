// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;
int num = Read("количество чисел");

int Read(string arg)
{
  System.Console.WriteLine($"Введите {arg}:");
  num = int.Parse(System.Console.ReadLine());
  return num;
}

for (int i = 0; i < num; i++)
{
    System.Console.WriteLine($"Введите число {i + 1}:");
    int number = int.Parse(System.Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}

System.Console.WriteLine($"Количество чисел больше нуля: {count}");