/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/


int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0) break;
    else Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
  }
  return result;
}

int CountSumOfNumbers(int maxNumber, int minNumber)
{
  if (maxNumber == minNumber) return minNumber;
  else return maxNumber + CountSumOfNumbers(maxNumber - 1, minNumber);
}

Console.WriteLine();
int minNumber = GetNaturalNumber("Введите минимальное натуральное число: ");
int maxNumber = GetNaturalNumber("Введите максимальное натуральное число: ");
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {minNumber} до {maxNumber} = {CountSumOfNumbers(maxNumber, minNumber)}");
