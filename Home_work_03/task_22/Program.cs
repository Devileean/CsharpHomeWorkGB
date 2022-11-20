// Задача №22.
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите число: ");
var num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i, 2));
}

// Console.Write("Введите число: ");
// var num = Convert.ToInt32(Console.ReadLine());
// var num2 =1;
// while (num2 <= num)
// {
//     Console.WriteLine(num2 * num2);
//     num2++;
// }
