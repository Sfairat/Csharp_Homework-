// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int a, int b)
{
    if(a == 0)
    {
        return b + 1;
    }
    else if(b == 0)
    {
        return Ackerman(a - 1, 1);
    }
    else
    {
        return Ackerman(a - 1, Ackerman(a, b - 1));
    }
}

if(m < 0 || n < 0)
{
    Console.WriteLine("Задано отрицательное число. Вычисление невозможно!");
}
else
{
    Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} будет равно {Ackerman(m, n)}.");
}