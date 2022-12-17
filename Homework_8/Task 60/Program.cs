// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArrayDiffNumbers(int[,,] array)
{
    int[] diff = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    for (int i = 0; i < diff.GetLength(0); i++)
    {
        diff[i] = new Random().Next(10, 100);
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (diff[i] == diff[j])
                {
                    diff[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    int index = 0; 
    for (int k = 0; k < array.GetLength(0); k++)
    { 
        for (int l = 0; l < array.GetLength(1); l++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
            array[k, l, m] = diff[index];
            index++;
            }
        }
    }
}

void PrintArrayByRows(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину массива: ");
int z = Convert.ToInt32(Console.ReadLine());

int [,,] nums = new int[x, y, z];
FillArrayDiffNumbers(nums);
PrintArrayByRows(nums);