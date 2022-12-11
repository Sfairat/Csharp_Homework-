// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverageColumns(int [,] arr)
{
    int index = 0;
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        double sum = 0;
        for (int l = 0; l < arr.GetLength(0); l++)
        {
            sum += arr[l, k];
        }
        index++;
        Console.WriteLine($"Среднее арифметическое элементов в столбце {index}: {Math.Round((sum / arr.GetLength(0)), 1)}.");
    }
}

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[m, n];
FillArray(nums);
Console.WriteLine();
FindAverageColumns(nums);