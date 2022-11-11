// Задача №1.
// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Введите число: ");
int num1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt16(Console.ReadLine());

int squareRoot = (num2 * num2);

if (num1 == squareRoot)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
} 

// не работает с 9 и -3

// int num1 = Convert.ToInt16(Console.ReadLine());
// int num2 = Convert.ToInt16(Console.ReadLine());

// if (Math.Sqrt(num1) == num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// } 