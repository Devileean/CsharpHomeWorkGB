// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiate(int numA, int numB)
{
    int result = (int) Math.Pow(numA, numB);
    return result;
    
}

Console.Write("Введите число A: ");
int anyNumA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int anyNumB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{anyNumA}, {anyNumB} -> " + Exponentiate(anyNumA,anyNumB));