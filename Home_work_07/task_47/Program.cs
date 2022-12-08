// Задача 47.
// Задайте двумерный массив размером m×n, заполненный
//  случайными вещественными числами. m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Exercise_47();
static void Exercise_47()
{
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9
    Console.WriteLine(
        "Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.");
    var numbers = GetEnteredNumbers("Введите число строк и число колонок :");
    if (numbers[0] != 0 && numbers[1] != 0)
    {
        var generatedTable = GenerateDoubleArray(numbers[0], numbers[1]);
        PrintDoubleTable(generatedTable);
    }
    else
    {
        Console.WriteLine("Заданные числа 0_0");
    }
            
}

static void PrintDoubleTable(double[,] generatedTable)
{
    for (int i = 0; i < generatedTable.GetLength(0); i++)
    {
        for (int j = 0; j < generatedTable.GetLength(1); j++)
        {
            Console.Write($"{generatedTable[i, j]} ");
        }
        Console.WriteLine();
    }
}

static double[,] GenerateDoubleArray(int m, int n)
{
    var tableArray = new double[m, n];
    var rand = new Random();
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i, j] = (double)rand.Next(-9, 10) + (double)Math.Round(rand.NextDouble(),2);
        }
    }
    return tableArray;
}

static int[] GetEnteredNumbers(string outputText = "")
{
    var arrayInts = Array.Empty<int>();
    Console.WriteLine(outputText);
    char[] separators = { ' ', ',' };
    var arrayOfEnteredText = Console.ReadLine()
        ?.Split(separators,
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    if (arrayOfEnteredText != null)
    {
        arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s));
    }
    return arrayInts;
}