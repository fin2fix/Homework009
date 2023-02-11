/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result >= 0) break;
    else Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
  }
  return result;
}

int CountAkkermanFuncion(int firstNumber, int secondNumber)
{
  if (firstNumber == 0)
    return secondNumber + 1;
  else
    if ((firstNumber != 0) && (secondNumber == 0))
    return CountAkkermanFuncion(firstNumber - 1, 1);
  else
    return CountAkkermanFuncion(firstNumber - 1, CountAkkermanFuncion(firstNumber, secondNumber - 1));
}

Console.WriteLine();
int firstNumber = GetNaturalNumber("Введите первое неотрицательное число: ");
int secondNumber = GetNaturalNumber("Введите второе неотрицательное число: ");
Console.WriteLine();
Console.WriteLine($"Результат функции Аккермана для чисел {firstNumber} и {secondNumber} = {CountAkkermanFuncion(firstNumber, secondNumber)}");
