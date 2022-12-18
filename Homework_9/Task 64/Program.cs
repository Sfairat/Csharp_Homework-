// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Nums(int a)
{
    if(a == 0) return;
    Nums(a - 1);
    Console.Write($"{N + 1 - a} ");
}

Console.Write($"Значения чисел в промежутке от {N} до 1 равны: ");
Nums(N);
Console.Write(".");