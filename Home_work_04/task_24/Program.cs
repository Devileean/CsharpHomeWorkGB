//  Задача 24: 
//  Напишите программу, которая принимает на вход число (А) 
//  и выдаёт сумма чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum(int num)// название метода пишем с большой буквы и как правило глагол
{
    int sum = 0;
    for(int i = 0; i <= num; i++)
    {
        sum += i; // каждый раз прибавляем к сумме sum = sum + i
    }
    return sum;
}

Console.WriteLine($"{num} -> {GetSum(num)}");