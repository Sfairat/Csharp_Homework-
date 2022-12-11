// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void FillArrayRealNumbers(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            int max = 20;
            int min = 10;
            var random = new Random();
            var randomDouble = random.NextDouble();
            collection[i, j] = Math.Round((randomDouble * max - min), 1);
            Console.Write($"{collection[i, j]} | ");
        }   
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] randomNums = new double [m, n];
FillArrayRealNumbers(randomNums);