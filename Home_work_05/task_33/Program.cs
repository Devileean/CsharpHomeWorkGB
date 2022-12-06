// Задача 33:
// Задайте массивюНапишите программу, которая определяет,
// присутствует ли заданное число в массиве.

//  4; массив [6, 7, 19, 345, 3] -> нет
//  3; массив [6, 7, 19, 345, 3] -> да

var array = FillArray(4);
Print(array);
if (FindNum(array, 6))
{
    Console.WriteLine("-> yes");
}
else
{
    Console.WriteLine("-> no");
}

bool FindNum(int[] arr, int num)
{
    foreach(var item in arr) // foreach работает только с массивами для переборки мосиива
    if(item == num)
    {
        return true;
    }
    return false;
}

int[] FillArray(int lenght)// заполнение массива
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(1, 15);
    }
    return array;
}

void Print(int[] array) // метод распечатки в консоль
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}
