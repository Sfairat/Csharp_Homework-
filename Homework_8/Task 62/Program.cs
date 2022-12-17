// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] nums = new int[rows, columns];

void FillArraySpiral(int[,] arr)
{
    int x = 0;
    int y = 0;
    int index = 1;

    while (rows > 0 && columns > 0)
    {
        for (int i = y; i <= y + columns - 1; i++)
        {
            arr[x, i] = index++;
        }
        for (int j = x + 1; j <= x + rows - 1; j++)
        {
            arr[j, y + columns - 1] = index++;
        }
        for (int k = y + columns - 2; k >= y; k--)
        {
            arr[x + rows - 1, k] = index++;
        }
        for (int l = x + rows - 2; l >= x + 1; l--)
        {
            arr[l, y] = index++;
        }
        x += 1;
        y += 1;
        rows -= 2;
        columns -= 2;
    }
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i, j] < 10) Console.Write($"0{col[i, j]} ");
            else Console.Write($"{col[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArraySpiral(nums);
PrintArray(nums);