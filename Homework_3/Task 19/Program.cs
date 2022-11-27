// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 10000 || a > 99999)
Console.WriteLine("Введено неверное число!");
else
{
    int[] array = new int[5];
    for (int i = 4; i >= 0; i--)
    {
        array[i] = a % 10;
        a = a / 10;
    }

    if(array[0] == array[4] && array[1] == array[3])
    Console.WriteLine("Введенное число является палиндромом!");
    else
    Console.WriteLine("Введенное число не является палиндромом!");
}