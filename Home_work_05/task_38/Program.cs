// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void Task38()  
{
    int num1 = GetNumber();               
    var arrayNumbers = GenerateArrayDoubles(num1, -99, 100);
    Console.WriteLine($"[{String.Join(", ", arrayNumbers)}]");
    Console.Write(" -> " + (Math.Abs(arrayNumbers.Max()) - Math.Abs(arrayNumbers.Min())));
}

double[] GenerateArrayDoubles(int num = 5, int from = -999, int to = 1000)
{
    var arr = new double[num];
    var random = new Random();
        for (var i = 0; i < num; i++)
        {
            arr[i] = random.Next(from, to) + random.NextDouble();
        }
        return arr;
}

int GetNumber()
{
    System.Console.WriteLine($"Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


Task38();