// Задача 30:
// Наппишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// х[1,0,1,1,0,1,0,0]

int[] anyArray = new int[8];
PrintArray(anyArray);
Console.WriteLine();
FillArray(anyArray);
PrintArray(anyArray);


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
