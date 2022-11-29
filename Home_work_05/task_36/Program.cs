// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Task36()  
{
    int anyNum = GetNumber();
    RandomNotEven(anyNum);
}

void RandomNotEven(int number)
{
    var randNum = new Random();
    int[] elementsArray = new int[number];
    int summ = 0;
    for (var i = 0; i < number; i++)
    {
        elementsArray[i] = randNum.Next(-99,100);
        if(i%2!=0)
        { 
        summ = summ + elementsArray[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях:");
    Console.WriteLine($"[{String.Join(", ", elementsArray)}] -> {summ}");
}

int GetNumber()
{
    Console.Write($"Введите колличество элементов массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Task36();