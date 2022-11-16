// Задача №14.
// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: "); 
int num = Convert.ToInt16(Console.ReadLine());
int seven = num % 7;
int twentythree = num % 23;

if (seven == 0 && twentythree ==0)
    Console.WriteLine($"{num} -> да");
else
     Console.WriteLine($"{num} -> нет");