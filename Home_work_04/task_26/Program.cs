//  Задача 26: 
//  Напишите программу, которая принимает на вход число  
//  и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите любое число: ");
int anyNum = Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int someNum)
{
   int length = 0;
   while (someNum > 0)
    {
        length++;
        someNum /= 10; // someNum = someNum / 10;
    }
    return length;
}

Console.WriteLine($"{anyNum} -> {NumberOfDigits(anyNum)}");