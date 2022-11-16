// Задача №16.
// Напишите программу, которая принимает на вход два числа
//и проверяет, является ли одно число квадратом другого.
// 5,25 -> да
// -4,16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt16(Console.ReadLine());

if (num2 % num1 == 0 || num1 % num2 == 0)
    Console.WriteLine($"{num1},{num2} -> да");
else
    Console.WriteLine($"{num1},{num2} -> нет");