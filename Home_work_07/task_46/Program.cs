// Задача 46: 
// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

// m = 3, n = 4.

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите количество строк в столбце");
//получаем строковые числа
Console.WriteLine("Введите количество строк");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int num2 = Convert.ToInt32(Console.ReadLine());

//создаем переменную arrayTable и назначаем ей введённые столбцы и строки
int[,] arrayTable = new int[num1,num2];
//создаем облачко случайных чисел
var random = new Random();

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i,j] = random.Next(-99,100);
        Console.Write($" {arrayTable[i,j]} ");
    }
    Console.WriteLine();
}