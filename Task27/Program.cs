﻿// Задача 27:
// Напишите программу, которая
// принимает на вход число
// и выдаёт сумму цифр в числе.
// 452  –> 11
// 82   –> 10
// 9012 –> 12

int SumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}.");
