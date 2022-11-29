// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2 

void Task34()
{
    int num1 = GetNum();
    RandomArray(num1);
}

void RandomArray(int number) // метод создания рандомного массива
{
    var randNum = new Random(); //случайное число
    int[] elementsArray = new int[number];
    int even = 0; // переменная для чётных
    for (var i = 0; i < number; i++)
    {
        elementsArray[i] = randNum.Next(100, 1000);
        if (elementsArray[i] % 2 == 0) //вычисляем четные элементы
        {
            even++;
        }
    }
    Console.WriteLine($"[{String.Join(", ", elementsArray)}] -> {even}");
}

int GetNum()// метод для введения числа
{
    Console.Write($"Введите колличество элементов массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Task34();