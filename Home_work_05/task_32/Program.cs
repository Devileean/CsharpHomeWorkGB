// Задача 32:
// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

var array = FillArray(4);
Print(array);
Console.Write("   ->   ");
ReplaceArray(array);
Print(array);

void ReplaceArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] FillArray(int lenght)// заполнение массива
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(-100, 100);
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
