﻿// Задача 15:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

  if (dayWeek == 6 || dayWeek == 7)
  {
  Console.WriteLine($"{dayWeek} -> выходной");
  }
  else if (dayWeek < 1 || dayWeek > 7)
  {
    Console.WriteLine($"{dayWeek} -> не относится ко дню недели");
  }
  else Console.WriteLine($"{dayWeek} -> не выходной");