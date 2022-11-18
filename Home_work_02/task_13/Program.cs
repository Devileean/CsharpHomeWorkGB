// Задача 13:
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//вариант с циклом(булевый)

// int random = new Random().Next(0,999999); можно с рандомом
// Console.WriteLine($"Случайное число: {random}");

Console.Write("Введите число от 0 - 9999999: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num; // переменная для красивого вывода
// number = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    for (bool i = false; i == false;)//булевое условие , можно было и по другому
    {
        if (num < 999) // проверка на трёхзначное
        {
            i = true;
            Console.WriteLine($"{num2} третья цифра -> {num % 10}");
        }
        else
        {
            num = num / 10; //будет убирать остаток пока не сработает - true
        }
    }
}
else if (num > 9 && num < 100) //проверка на двухзначное
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    Console.WriteLine("Всего одна цифра"); // тут и так всё понятно
} 

//  вариант с строкой
// //вводим число
// Console.Write("Введите число: ");

// //создаём переменную inputUserText которой присваиваем значение Console.Write
// string inputUserText =(Console.ReadLine())??"";

// //создаём условие:  если переменная inputUserText.Length больше 2,то
//     if (inputUserText.Length > 2)
//     { //то консоль выводит на экран текст "третья цифра -> и обращается ко второму элементу массива и пишет его значение"
//   Console.WriteLine("третья цифра -> " + inputUserText[2]);
//     }
//     else
//     { //иначе если значение переменной inputUserText.Length меньше двух, то коносль выводит текст "третьей цифры нет"
//   Console.WriteLine("-> третьей цифры нет");
//     } 