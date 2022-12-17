// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
            Console.Write($"{collection[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindMinRow(int [,] arr)
{
    int minRow = 0;
    int index = 0;
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        int sum = 0;
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            sum += arr[k, l];
        }
        if (minRow == 0)
        {
            minRow = sum;
            index = k + 1;
        }
        else if (minRow > sum) 
        {
            minRow = sum;
            index = k + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в заданном массиве в {index} строке и равна: {minRow}.");
}

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[m, n];
FillArray(nums);
Console.WriteLine();
FindMinRow(nums);