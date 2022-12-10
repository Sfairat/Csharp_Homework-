// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите любое количество чисел в строку: ");
string numberM = Console.ReadLine() ?? String.Empty;
string[] tempArray = numberM.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
int[] arrayM = tempArray.Select(Int32.Parse).ToArray();

int i = 0;
foreach (var num in arrayM)
{
    if (num > 0)
    {
        i++;
    }
}
Console.WriteLine($"Введено чисел больше нуля: {i}.");