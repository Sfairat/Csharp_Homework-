// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.WriteLine("Введите число элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int i = 0;
foreach (var num in array)
{
    if (num % 2 == 0)
    {
        i++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {i}");