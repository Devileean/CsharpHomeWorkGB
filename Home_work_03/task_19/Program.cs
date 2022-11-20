// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
var fiveDigitNum = Convert.ToInt32(Console.ReadLine());

var firstNum = fiveDigitNum / 10000; //первые цыфры для сравнения
var lastNum = fiveDigitNum % 10;     //первые цыфры для сравнения

var secondNum = (fiveDigitNum / 1000) % 10;//вторые цифры для сравнения
var fourthNum = (fiveDigitNum % 100) / 10; //вторые цифры для сравнения

if (fiveDigitNum > 9999 && fiveDigitNum <= 99999)
{
    if (firstNum == lastNum && secondNum == fourthNum)
    {
        Console.WriteLine($"{fiveDigitNum} -> является палиндромом {firstNum}{secondNum} {fourthNum}{lastNum}");
    }
    else
    {
        Console.WriteLine($"{fiveDigitNum} -> не является палиндромом");
    }    
}
else
{
    Console.WriteLine("вы ввели не правильное число");
}
