// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.




int[] array = massiv(8);    
Console.WriteLine($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");

int[] massiv(int size)
{
    int[] result = new int[size];
    for (int i = 0 ; i < size ; i++)
    {
        result[i] = new Random().Next(0, 50);
    }
    return result;
}