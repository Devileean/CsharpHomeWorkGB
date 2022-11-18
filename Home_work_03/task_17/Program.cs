// Задача №17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите Кординаты X и Y");
Console.Write("X : ");
var x = Convert.ToInt16(Console.ReadLine());
Console.Write("Y : ");
var y = Convert.ToInt16(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine($"({x},{y}) 1-ая плоскость четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine($"({x},{y}) 2-ая плоскость четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine($"({x},{y}) 3-ья плоскость четверти");
}
else
{
    Console.WriteLine($"({x},{y}) 4-ая плоскость четверти");
}
