// Задача 42:
// Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования
var arr1 = FillArray(9);
Print(arr1);

Console.WriteLine();

var arr2 = CopyMassive(arr1);
Print(arr2);

int[] CopyMassive(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int[] FillArray(int lenght)// заполнение массива
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(1, 10);
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