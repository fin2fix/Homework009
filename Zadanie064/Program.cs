/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }

  return result;
}

void PrintNumber(int maxNumber, int minNumber)
{
  if (maxNumber >= minNumber)
  {
    Console.Write($"{maxNumber} ");
    maxNumber--;
    PrintNumber(maxNumber, minNumber);
  }
}

Console.WriteLine();
int minNumber = 1;
int maxNumber = GetNaturalNumber("Введите натуральное число: ");
Console.WriteLine();
Console.WriteLine($"Числа от {maxNumber} до {minNumber} это: ");
PrintNumber(maxNumber, minNumber);