// Задача №3. 
// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());

if (num == 1) 
    Console.WriteLine("Monday");
else if (num == 2)
    Console.WriteLine("Tuesday");
else if (num == 3)
    Console.WriteLine("Wednesday");
else if (num == 4)
    Console.WriteLine("Thursday");
else if (num == 5)
    Console.WriteLine("Friday");
else if (num == 6)
    Console.WriteLine("Saturday");
else if (num == 7)
    Console.WriteLine("Sunday");
