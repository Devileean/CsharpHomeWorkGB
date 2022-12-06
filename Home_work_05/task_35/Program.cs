// Задача 35:
// Задайте одномерный массив из 123 случайных чисел.
// Найдите колличество элементов массива, значения которых лежат в отрезке [10, 99].
// Пример для массива из 5, а не из 123 элементов. В своём решении сделайте для 123.

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

var array = FillArray(5);
Print(array);
Console.WriteLine();
Console.WriteLine(GetCount(array));

int GetCount(int[] array)
{
    int count = 0;
    foreach(var item in array)
    {
        if(item >= 10 && item <= 99)
        {
            count++;
        }
    }
    return count;
}



int[] FillArray(int lenght)// заполнение массива
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(1, 500);
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