namespace Task_menu;

public static class Homework07
{
    /// <summary>
    ////Отрисовка меню и запуск выбраных функций
    /// </summary>
    public static void Main()
    {
        var menuItems = new string[] { "Задача 47", "Задача 50","Задача 52", "Выход" };

        Console.WriteLine("Меню");
        Console.WriteLine();

        var row = Console.CursorTop;
        var col = Console.CursorLeft;
        var index = 0;
        while (true)
        {
            // для разообразия выкинул в отдельный класс
            Menu.DrawMenu(menuItems, row, col, index);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (index < menuItems.Length - 1)
                        index++;
                    Console.Clear();
                    break;
                case ConsoleKey.UpArrow:
                    if (index > 0)
                        index--;
                    Console.Clear();
                    break;
                case ConsoleKey.Enter:
                    if (index == 0)
                        Exercise_47();
                    else if (index == 1)
                        Exercise_50();
                    else if (index == 2)
                        Exercise_52();
                    else if (index == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Выбран выход из приложения");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Выбрана {menuItems[index]}");
                        
                    }

                    break;
            }
        }
    }
    
/// <summary>
/// Задача 47
/// </summary>
    static void Exercise_47()
    {

    }
/// <summary>
/// Задача 50
/// </summary>
    static void Exercise_50()
{
    var geter = GetEnteredNumbers("param");
    Console.Write(String.Join(", ", geter));
    
}
/// <summary>
/// Задача 52
/// </summary>
    static void Exercise_52()
    {

    }

/// <summary>
/// Функция получает текст и просит ввести данные в строку через запятую или пробел
/// </summary>
/// <param name="outputText"></param>
/// <returns></returns>
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



}