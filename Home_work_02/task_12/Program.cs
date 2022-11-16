// Задача №12.
// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. Если 
// число 2 не кратночислу 1, то программа выводит остаток от
// деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: "); 
int num1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt16(Console.ReadLine());

int remainder = num1 % num2; //остаток от первого
if (remainder == 0) // если остаток нулевой 
    Console.WriteLine($"{num1}, {num2} -> кратно");
else 
    Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {remainder}");