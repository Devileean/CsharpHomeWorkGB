﻿// Задача 8:
// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int? num;
int i = 1;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num != null)
{
    while (i <= num)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
}

