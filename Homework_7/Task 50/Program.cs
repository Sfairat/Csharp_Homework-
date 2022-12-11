// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента (два числа) массива для поиска: ");
string find = Console.ReadLine() ?? String.Empty;
string[] tempArray = find.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

int[] findArray = tempArray.Select(Int32.Parse).ToArray();
findArray[0] -= 1; findArray[1] -= 1;

int[,] nums = new int[m, n];
FillArray(nums);

if (findArray.Length < 2)
{
    Console.WriteLine("Такой элемент в массиве отсутствует.");
}
else 
    if (findArray.Length <= 2 && findArray[0] >= 0 && findArray[0] < m && findArray[1] >= 0 && findArray[1] < n)
    {
        int findNumber = nums[findArray[0], findArray[1]];
        Console.WriteLine($"Значение элемента массива на позиции ({find}) равно: {findNumber}");
    }
    else
    {
        Console.WriteLine("Такой элемент в массиве отсутствует.");
    }