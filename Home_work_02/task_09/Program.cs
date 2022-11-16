// Задача №9.
// Напишите программу, которая выводит случайное число из отрезка[10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8
// int firstNum = 0;
// int secondNum = 0;
int random = new Random().Next(10, 99);
Console.WriteLine($"Случайное число: {random}");
int random2 = random;
int maxNum = 0;
  
do maxNum = random % 10 > maxNum ? random % 10 : maxNum;
while ((random /= 10) != 0);
 
Console.WriteLine($"{random2} -> {maxNum}");
