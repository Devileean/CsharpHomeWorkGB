// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
//     
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

var numbers = GetEnteredNumbers("введите с клавиатуры M чисел: ");
var plusNum = SortedNumbers(numbers);
Console.WriteLine($"{String.Join(", " , numbers)} -> {plusNum}");

int SortedNumbers(int[] anyArray)
{
    var count = 0;
    foreach (var item in anyArray)
    {
        if (item > 0)
            count++;
    }
    return count;
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