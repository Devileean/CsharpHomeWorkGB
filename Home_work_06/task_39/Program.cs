// Задача 39:
// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = FillArray(6);
Print(array);
Console.Write(" ->  ");
Print(ReverseArray(array));

int[] ReverseArray(int[] array)
{
    int lenght = array.Length;
    int[] result = new int[lenght];
    for(int i = lenght-1; i >= 0; i--)
    {
        result[lenght-1-i] = array[i];
    }

    return result;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}