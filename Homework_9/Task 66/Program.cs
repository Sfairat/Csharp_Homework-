// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Nums(int a, int b)
{
    if(a == b) return b;
    else return a + Nums(a + 1, b);
}

Console.WriteLine($"Сумма элементов между числами M и N равна: {Nums(M, N)}.");