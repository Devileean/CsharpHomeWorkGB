// Задача №18.
//  Напишите программу, которая по заданному номеру четверти, 
//  показывает диапазон возможных координат точек в этой четверти (x и y).

try 
{
    Console.Write("Введите номер четверти координат: ");
    var quarter = Convert.ToUInt16(Console.ReadLine());
    switch (quarter)
    {
        case 1:
            Console.WriteLine("x > 0 and y > 0");
            break;
        case 2:
            Console.WriteLine("x < 0 and y > 0");
            break;        
        case 3:
            Console.WriteLine("x < 0 and y < 0"); 
            break;      
        case 4:
            Console.WriteLine("x > 0 and y < 0");
            break;
        default:
            Console.WriteLine("не существует такой плоскости");
            break;
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}