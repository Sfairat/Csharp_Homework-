// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;

if(a > b)
{
    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Мимамальное число: {min}");
}
else
    if(a < b)
    {   
        max = b;
        min = a;
        Console.WriteLine($"Максимальное число: {max}");
        Console.WriteLine($"Мимамальное число: {min}");
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
