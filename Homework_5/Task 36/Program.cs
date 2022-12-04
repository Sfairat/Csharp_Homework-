// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-99, 100);
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

int sum = 0;
for (int i = 0; i < a; i += 2)
{
    sum += array[i];
}
Console.WriteLine($"Сумма нечетных элементов массива равна: {sum}");