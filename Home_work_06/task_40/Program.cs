// Задача 40:
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли cуществовать треугольник со сторонами такой длинны.

Console.WriteLine("Напишите программу, которая принимает на вход три числа и проверяет," + 
                  "может ли чуществовать треугольник со сторонами такой длинны.");

Console.Write("Введите первое число: ");
var numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
var numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
var numC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
IsTriangle(numA,numB,numC);

bool IsTriangle(int a,int b, int c)
{
    if(((a+b) > c) && ((b+c) > a) && ((a+c) > b))
    {
        Console.WriteLine("треугольник может существовать");
    }
    else
    {
        Console.WriteLine("треугольник не может существовать");
    }
    return true;
}

//другой вариант записи

// bool IsTriangle(int a,int b, int c)
// {
//     return(((a+b) > c) && ((b+c) > a) && ((a+c) > b));
// }