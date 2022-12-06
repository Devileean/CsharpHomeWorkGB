// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// парой считаем первый и последний элемент, второй и предпоследний
// и т.д.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

var array = FillArray(4);
Print(array);
Console.WriteLine();
int[] newArray = MultiplyPair(array);
Print(newArray);

int[] MultiplyPair(int[] array)
{
    int newLenght = 0;
    if(array.Length %2 == 0)
    {
        newLenght = array.Length / 2;
    }
    else
    {
        newLenght = array.Length / 2 + 1;
    }
    int[] result = new int[newLenght];

    for(int i = 0; i < newLenght; i++)
    {
        result[i] = array[i] * array[array.Length -1 - i];
    }

    return result;
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