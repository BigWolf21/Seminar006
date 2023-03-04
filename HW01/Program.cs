// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int GetNumber(string text)
{
  int value = 0;
  bool flag = false;
  while (!flag)
  {
    Console.Write(text);
    flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

int[] CreateArray(int size)
{
  return new int[size];
}

void FillByUser(int[] array)
{
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    array[i] = GetNumber($"Введите {i + 1} элемент: - ");
  }
}

string Print(int[] array)
{
  string result = String.Empty;
  int len = array.Length;
  for (int i = 0; i < len; i++)
  {
    result += array[i] + ", ";
  }
  return result;
}

int Account(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count += +1;
    }
  }
  return count;
}

int value = GetNumber("Какое множество чисел будет введенно - ");
int[] array = CreateArray(value);
FillByUser(array);
Console.WriteLine($"[{Print(array)}]");
Console.WriteLine($"Количество чисел больше '0' = {Account(array)}");