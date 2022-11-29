// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = MakeMassiv(3);    
Console.WriteLine($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");

int[] MakeMassiv(int size)
{
    int[] result = new int[size];
    for (int i = 0 ; i < size ; i++)
    {
        result[i] = new Random().Next(0, 50);
    }
    return result;
}

//Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

// void z29()
// {
    
//     var num = new[] { 0 , 1 , 2 , 3 , 4 , 5 , 6 , 7 };
//     var counter = 0;
//     while (num.Length > counter)
//     {
//         Console.Write(num[counter]);
//         counter++;
//     }

// }
// z29();
