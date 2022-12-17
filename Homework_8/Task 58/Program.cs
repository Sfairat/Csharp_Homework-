// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] matr1, int[,] matr2, int[,] multiMatrix)
{
  for (int i = 0; i < multiMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < multiMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matr1.GetLength(1); k++)
      {
        sum += matr1[i, k] * matr2[k, j];
      }
      multiMatrix[i, j] = sum;
    }
  }
}

Console.WriteLine("Введите число строк и столбцов в матрицах: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[m, m];
int[,] matrix2 = new int[m, m];
int[,] multiMatrix = new int[m, m];

FillArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
Console.WriteLine();
MatrixMultiplication(matrix1, matrix2, multiMatrix);
PrintArray(multiMatrix);