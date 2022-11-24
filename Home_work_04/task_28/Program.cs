//  Задача 28: 
//  Напишите программу, которая принимает на вход число N 
//  и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int GetMultiply(int someNum)
{
    int multiply = someNum;
    for(int i = 1; i < someNum; i++)
    {
        multiply *= i; // multiply = multiply * 10;
    }
    return multiply;
}

Console.Write("Введите любое число: ");
int anyNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{anyNum} -> {GetMultiply(anyNum)}");