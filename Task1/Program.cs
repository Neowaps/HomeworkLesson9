// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


System.Console.Write("Введите N: ");
int n = int.Parse(System.Console.ReadLine());

string SumNumbers(int numEnd) => numEnd == 1 ? numEnd.ToString() : numEnd + " " + SumNumbers(numEnd - 1);
// {
//     if (numEnd == 0) 
// {
//     return numEnd;
// }
// else
// {
//     System.Console.Write(numEnd + " ");
//     return numEnd + SumNumbers(numEnd - 1);
// }
// }

string sum = SumNumbers(n);
System.Console.Write($"Все натуральные числа в промежутке от {n} до 1: {sum}");
