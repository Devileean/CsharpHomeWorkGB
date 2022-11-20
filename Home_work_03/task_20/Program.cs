﻿// // Задача №20.
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//Math.Sqrt(число); квадратный корень числа
//Math.Pow(число, 2); возводит в квадрат
Console.WriteLine("Введите координаты точки: A");
Console.Write("x1: ");
var x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
var y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки: B");
Console.Write("x2: ");
var x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
var y2 = Convert.ToDouble(Console.ReadLine());

//AB = √(xb - xa)2 + (yb - ya)2
var distance =(double) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//var distanceConsole = Convert.ToDouble("{0: 0.00}", distance);
//Console.WriteLine(distance);$"A ({x1},{y1}); B ({x2},{y2}) -> {(
Console.Write($"A ({x1},{y1}); B ({x2},{y2}) ->");
Console.WriteLine("{0: 0.00}", distance); // округляем до двух знаков после запятой