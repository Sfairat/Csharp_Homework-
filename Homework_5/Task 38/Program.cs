// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    double upperNum = 100;
    double lowerNum = 1;
    while(index < length)
    {
        var random = new Random();
        var randomDouble = random.NextDouble();
        collection[index] = randomDouble * (upperNum - lowerNum) * lowerNum;
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
return max;
}

double FindMin(double[] arr1)
{
    double min = arr1[0];
    for (int j = 1; j < arr1.Length; j++)
    {
        if (arr1[j] < min)
        {
            min = arr1[j];
        }
    }
return min;
}

Console.WriteLine("Введите число элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double diff = 0;
double[] array = new double[a];

FillArray(array);
PrintArray(array);
Console.WriteLine();

diff = FindMax(array) - FindMin(array);
diff = Math.Round(diff, 3);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {diff}");